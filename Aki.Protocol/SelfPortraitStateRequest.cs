using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FC RID: 4604
	[NetMessage(EMessageId.SelfPortraitStateRequest)]
	public sealed class SelfPortraitStateRequest : IMessage<SelfPortraitStateRequest>, IMessage, IEquatable<SelfPortraitStateRequest>, IDeepCloneable<SelfPortraitStateRequest>, IBufferMessage
	{
		// Token: 0x060189B9 RID: 100793 RVA: 0x0039721C File Offset: 0x0039541C
		[NullableContext(1)]
		public static SelfPortraitStateRequest Create()
		{
			return new SelfPortraitStateRequest();
		}

		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x060189BA RID: 100794 RVA: 0x00397223 File Offset: 0x00395423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x060189BB RID: 100795 RVA: 0x00397226 File Offset: 0x00395426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfPortraitStateRequest.Descriptor;
			}
		}

		// Token: 0x060189BC RID: 100796 RVA: 0x0039722D File Offset: 0x0039542D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest()
		{
		}

		// Token: 0x060189BD RID: 100797 RVA: 0x00397235 File Offset: 0x00395435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest(SelfPortraitStateRequest other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189BE RID: 100798 RVA: 0x0039725A File Offset: 0x0039545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfPortraitStateRequest Clone()
		{
			return new SelfPortraitStateRequest(this);
		}

		// Token: 0x17005325 RID: 21285
		// (get) Token: 0x060189BF RID: 100799 RVA: 0x00397262 File Offset: 0x00395462
		// (set) Token: 0x060189C0 RID: 100800 RVA: 0x0039726A File Offset: 0x0039546A
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

		// Token: 0x060189C1 RID: 100801 RVA: 0x00397273 File Offset: 0x00395473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfPortraitStateRequest);
		}

		// Token: 0x060189C2 RID: 100802 RVA: 0x00397281 File Offset: 0x00395481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfPortraitStateRequest other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189C3 RID: 100803 RVA: 0x003972B0 File Offset: 0x003954B0
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

		// Token: 0x060189C4 RID: 100804 RVA: 0x003972F5 File Offset: 0x003954F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189C5 RID: 100805 RVA: 0x00397302 File Offset: 0x00395502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189C6 RID: 100806 RVA: 0x0039730B File Offset: 0x0039550B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != SelfPortraitOpState.SelfPortraitEnter)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189C7 RID: 100807 RVA: 0x00397340 File Offset: 0x00395540
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

		// Token: 0x060189C8 RID: 100808 RVA: 0x0039737E File Offset: 0x0039557E
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

		// Token: 0x060189C9 RID: 100809 RVA: 0x003973AF File Offset: 0x003955AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189CA RID: 100810 RVA: 0x003973B8 File Offset: 0x003955B8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.State = (SelfPortraitOpState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400925D RID: 37469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400925E RID: 37470
		public const int StateFieldNumber = 13;

		// Token: 0x0400925F RID: 37471
		private SelfPortraitOpState state_;
	}
}
