using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C2 RID: 4546
	[NetMessage(EMessageId.SelfPortraitStateRequest)]
	public sealed class SelfPortraitStateRequest : IMessage<SelfPortraitStateRequest>, IMessage, IEquatable<SelfPortraitStateRequest>, IDeepCloneable<SelfPortraitStateRequest>, IBufferMessage
	{
		// Token: 0x06018418 RID: 99352 RVA: 0x00387EE8 File Offset: 0x003860E8
		[NullableContext(1)]
		public static SelfPortraitStateRequest Create()
		{
			return new SelfPortraitStateRequest();
		}

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x06018419 RID: 99353 RVA: 0x00387EEF File Offset: 0x003860EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x0601841A RID: 99354 RVA: 0x00387EF2 File Offset: 0x003860F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfPortraitStateRequest.Descriptor;
			}
		}

		// Token: 0x0601841B RID: 99355 RVA: 0x00387EF9 File Offset: 0x003860F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest()
		{
		}

		// Token: 0x0601841C RID: 99356 RVA: 0x00387F01 File Offset: 0x00386101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest(SelfPortraitStateRequest other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601841D RID: 99357 RVA: 0x00387F26 File Offset: 0x00386126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest Clone()
		{
			return new SelfPortraitStateRequest(this);
		}

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x0601841E RID: 99358 RVA: 0x00387F2E File Offset: 0x0038612E
		// (set) Token: 0x0601841F RID: 99359 RVA: 0x00387F36 File Offset: 0x00386136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitOpState State
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

		// Token: 0x06018420 RID: 99360 RVA: 0x00387F3F File Offset: 0x0038613F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfPortraitStateRequest);
		}

		// Token: 0x06018421 RID: 99361 RVA: 0x00387F4D File Offset: 0x0038614D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfPortraitStateRequest other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018422 RID: 99362 RVA: 0x00387F7C File Offset: 0x0038617C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != SelfPortraitOpState.SelfPortraitEnter)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018423 RID: 99363 RVA: 0x00387FC1 File Offset: 0x003861C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018424 RID: 99364 RVA: 0x00387FCE File Offset: 0x003861CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018425 RID: 99365 RVA: 0x00387FD7 File Offset: 0x003861D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != SelfPortraitOpState.SelfPortraitEnter)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018426 RID: 99366 RVA: 0x0038800C File Offset: 0x0038620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != SelfPortraitOpState.SelfPortraitEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018427 RID: 99367 RVA: 0x0038804A File Offset: 0x0038624A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelfPortraitStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != SelfPortraitOpState.SelfPortraitEnter)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018428 RID: 99368 RVA: 0x0038807B File Offset: 0x0038627B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018429 RID: 99369 RVA: 0x00388084 File Offset: 0x00386284
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.State = (SelfPortraitOpState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FCA RID: 36810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FCB RID: 36811
		public const int StateFieldNumber = 15;

		// Token: 0x04008FCC RID: 36812
		private SelfPortraitOpState state_;
	}
}
