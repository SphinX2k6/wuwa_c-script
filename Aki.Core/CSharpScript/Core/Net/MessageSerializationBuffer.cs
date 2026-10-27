using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Core.Net
{
	// Token: 0x0200012D RID: 301
	public readonly struct MessageSerializationBuffer : IDisposable
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00034AB3 File Offset: 0x00032CB3
		public Span<byte> MessageSpan
		{
			get
			{
				return new Span<byte>(this.Buffer, 0, this.MessageSize);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00034AC7 File Offset: 0x00032CC7
		public int Length
		{
			get
			{
				return this.MessageSize;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00034ACF File Offset: 0x00032CCF
		private MessageSerializationBuffer(int messageSize)
		{
			this.Buffer = Array.Empty<byte>();
			this.MessageSize = 0;
			this.Buffer = ArrayPool<byte>.Shared.Rent(messageSize);
			this.MessageSize = messageSize;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00034AFB File Offset: 0x00032CFB
		public void Dispose()
		{
			if (this.Buffer != null)
			{
				ArrayPool<byte>.Shared.Return(this.Buffer, false);
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00034B18 File Offset: 0x00032D18
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

		// Token: 0x040006B2 RID: 1714
		[Nullable(1)]
		private readonly byte[] Buffer;

		// Token: 0x040006B3 RID: 1715
		private readonly int MessageSize;
	}
}
