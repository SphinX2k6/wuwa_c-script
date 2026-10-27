using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045B RID: 1115
	[NetMessage(EMessageId.EnterViewDirectionPush)]
	public sealed class EnterViewDirectionPush : IMessage<EnterViewDirectionPush>, IMessage, IEquatable<EnterViewDirectionPush>, IDeepCloneable<EnterViewDirectionPush>, IBufferMessage
	{
		// Token: 0x06006A92 RID: 27282 RVA: 0x00101418 File Offset: 0x000FF618
		[NullableContext(1)]
		public static EnterViewDirectionPush Create()
		{
			return new EnterViewDirectionPush();
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06006A93 RID: 27283 RVA: 0x0010141F File Offset: 0x000FF61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x00101422 File Offset: 0x000FF622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionPush.Descriptor;
			}
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x00101429 File Offset: 0x000FF629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush()
		{
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x00101431 File Offset: 0x000FF631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush(EnterViewDirectionPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x0010144A File Offset: 0x000FF64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush Clone()
		{
			return new EnterViewDirectionPush(this);
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x00101452 File Offset: 0x000FF652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionPush);
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00101460 File Offset: 0x000FF660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00101480 File Offset: 0x000FF680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x001014A6 File Offset: 0x000FF6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x001014B3 File Offset: 0x000FF6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x001014BC File Offset: 0x000FF6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x001014D4 File Offset: 0x000FF6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x001014FA File Offset: 0x000FF6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterViewDirectionPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x00101517 File Offset: 0x000FF717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00101520 File Offset: 0x000FF720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A55 RID: 14933
		private UnknownFieldSet _unknownFields;
	}
}
