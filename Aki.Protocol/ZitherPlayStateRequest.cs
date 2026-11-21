using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A9 RID: 5545
	[NetMessage(EMessageId.ZitherPlayStateRequest)]
	public sealed class ZitherPlayStateRequest : IMessage<ZitherPlayStateRequest>, IMessage, IEquatable<ZitherPlayStateRequest>, IDeepCloneable<ZitherPlayStateRequest>, IBufferMessage
	{
		// Token: 0x0601D589 RID: 120201 RVA: 0x0043F521 File Offset: 0x0043D721
		[NullableContext(1)]
		public static ZitherPlayStateRequest Create()
		{
			return new ZitherPlayStateRequest();
		}

		// Token: 0x17006347 RID: 25415
		// (get) Token: 0x0601D58A RID: 120202 RVA: 0x0043F528 File Offset: 0x0043D728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006348 RID: 25416
		// (get) Token: 0x0601D58B RID: 120203 RVA: 0x0043F52B File Offset: 0x0043D72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayStateRequest.Descriptor;
			}
		}

		// Token: 0x0601D58C RID: 120204 RVA: 0x0043F532 File Offset: 0x0043D732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest()
		{
		}

		// Token: 0x0601D58D RID: 120205 RVA: 0x0043F53A File Offset: 0x0043D73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest(ZitherPlayStateRequest other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D58E RID: 120206 RVA: 0x0043F55F File Offset: 0x0043D75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest Clone()
		{
			return new ZitherPlayStateRequest(this);
		}

		// Token: 0x17006349 RID: 25417
		// (get) Token: 0x0601D58F RID: 120207 RVA: 0x0043F567 File Offset: 0x0043D767
		// (set) Token: 0x0601D590 RID: 120208 RVA: 0x0043F56F File Offset: 0x0043D76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherOpState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0601D591 RID: 120209 RVA: 0x0043F578 File Offset: 0x0043D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayStateRequest);
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x0043F586 File Offset: 0x0043D786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayStateRequest other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x0043F5B4 File Offset: 0x0043D7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != ZitherOpState.OpEnter)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D594 RID: 120212 RVA: 0x0043F5F9 File Offset: 0x0043D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D595 RID: 120213 RVA: 0x0043F606 File Offset: 0x0043D806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D596 RID: 120214 RVA: 0x0043F60F File Offset: 0x0043D80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != ZitherOpState.OpEnter)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D597 RID: 120215 RVA: 0x0043F644 File Offset: 0x0043D844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != ZitherOpState.OpEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D598 RID: 120216 RVA: 0x0043F682 File Offset: 0x0043D882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != ZitherOpState.OpEnter)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D599 RID: 120217 RVA: 0x0043F6B3 File Offset: 0x0043D8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D59A RID: 120218 RVA: 0x0043F6BC File Offset: 0x0043D8BC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.State = (ZitherOpState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A833 RID: 43059
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A834 RID: 43060
		public const int StateFieldNumber = 8;

		// Token: 0x0400A835 RID: 43061
		private ZitherOpState state_;
	}
}
