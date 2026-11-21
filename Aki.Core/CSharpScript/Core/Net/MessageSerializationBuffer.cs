using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Core.Net
{
	// Token: 0x0200012E RID: 302
	public readonly struct MessageSerializationBuffer : IDisposable
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00035527 File Offset: 0x00033727
		public Span<byte> MessageSpan
		{
			get
			{
				return new Span<byte>(this.Buffer, 0, this.MessageSize);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0003553B File Offset: 0x0003373B
		public int Length
		{
			get
			{
				return this.MessageSize;
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00035543 File Offset: 0x00033743
		private MessageSerializationBuffer(int messageSize)
		{
			this.Buffer = Array.Empty<byte>();
			this.MessageSize = 0;
			this.Buffer = ArrayPool<byte>.Shared.Rent(messageSize);
			this.MessageSize = messageSize;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0003556F File Offset: 0x0003376F
		public void Dispose()
		{
			if (this.Buffer != null)
			{
				ArrayPool<byte>.Shared.Return(this.Buffer, false);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0003558C File Offset: 0x0003378C
		[NullableContext(1)]
		public unsafe static MessageSerializationBuffer GetBuffer(EMessageId msgId, IMessage message)
		{
			int messageSize = message.CalculateSize();
			MessageSerializationBuffer messageSerializationBuffer = new MessageSerializationBuffer(messageSize);
			MessageSerializationBuffer result;
			try
			{
				message.WriteTo(messageSerializationBuffer.MessageSpan);
				result = messageSerializationBuffer;
			}
			catch (Exception ex)
			{
				messageSerializationBuffer.Dispose();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Net;
				ELogAuthor author = ELogAuthor.LRX;
				string message2 = "消息写入失败!";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ex:", ex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("msgId:", msgId);
				instance.Error(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("消息 ");
				defaultInterpolatedStringHandler.AppendFormatted<EMessageId>(msgId);
				defaultInterpolatedStringHandler.AppendLiteral(" 序列化失败");
				throw new SerializationException(defaultInterpolatedStringHandler.ToStringAndClear(), ex);
			}
			return result;
		}

		// Token: 0x040006C0 RID: 1728
		[Nullable(1)]
		private readonly byte[] Buffer;

		// Token: 0x040006C1 RID: 1729
		private readonly int MessageSize;
	}
}
