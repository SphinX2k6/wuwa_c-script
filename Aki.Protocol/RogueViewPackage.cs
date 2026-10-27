using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001028 RID: 4136
	public sealed class RogueViewPackage : IMessage<RogueViewPackage>, IMessage, IEquatable<RogueViewPackage>, IDeepCloneable<RogueViewPackage>, IBufferMessage
	{
		// Token: 0x060161B1 RID: 90545 RVA: 0x00336409 File Offset: 0x00334609
		[NullableContext(1)]
		public static RogueViewPackage Create()
		{
			return new RogueViewPackage();
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x060161B2 RID: 90546 RVA: 0x00336410 File Offset: 0x00334610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x060161B3 RID: 90547 RVA: 0x00336413 File Offset: 0x00334613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewPackage.Descriptor;
			}
		}

		// Token: 0x060161B4 RID: 90548 RVA: 0x0033641A File Offset: 0x0033461A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage()
		{
		}

		// Token: 0x060161B5 RID: 90549 RVA: 0x0033642D File Offset: 0x0033462D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage(RogueViewPackage other) : this()
		{
			this.rogueViewGroups_ = other.rogueViewGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161B6 RID: 90550 RVA: 0x00336457 File Offset: 0x00334657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage Clone()
		{
			return new RogueViewPackage(this);
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x060161B7 RID: 90551 RVA: 0x0033645F File Offset: 0x0033465F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueViewGroup> RogueViewGroups
		{
			get
			{
				return this.rogueViewGroups_;
			}
		}

		// Token: 0x060161B8 RID: 90552 RVA: 0x00336467 File Offset: 0x00334667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewPackage);
		}

		// Token: 0x060161B9 RID: 90553 RVA: 0x00336475 File Offset: 0x00334675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewPackage other)
		{
			return other != null && (other == this || (this.rogueViewGroups_.Equals(other.rogueViewGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161BA RID: 90554 RVA: 0x003364A8 File Offset: 0x003346A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueViewGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060161BB RID: 90555 RVA: 0x003364DC File Offset: 0x003346DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161BC RID: 90556 RVA: 0x003364E9 File Offset: 0x003346E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161BD RID: 90557 RVA: 0x003364F2 File Offset: 0x003346F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueViewGroups_.WriteTo(ref output, RogueViewPackage._repeated_rogueViewGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161BE RID: 90558 RVA: 0x0033651C File Offset: 0x0033471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueViewGroups_.CalculateSize(RogueViewPackage._repeated_rogueViewGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161BF RID: 90559 RVA: 0x00336555 File Offset: 0x00334755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueViewPackage other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueViewGroups_.Add(other.rogueViewGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161C0 RID: 90560 RVA: 0x00336583 File Offset: 0x00334783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161C1 RID: 90561 RVA: 0x0033658C File Offset: 0x0033478C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueViewGroups_.AddEntriesFrom(ref input, RogueViewPackage._repeated_rogueViewGroups_codec);
				}
			}
		}

		// Token: 0x04008469 RID: 33897
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400846A RID: 33898
		public const int RogueViewGroupsFieldNumber = 1;

		// Token: 0x0400846B RID: 33899
		private static readonly FieldCodec<RogueViewGroup> _repeated_rogueViewGroups_codec = FieldCodec.ForMessage<RogueViewGroup>(10U, RogueViewGroup.Parser);

		// Token: 0x0400846C RID: 33900
		private readonly RepeatedField<RogueViewGroup> rogueViewGroups_ = new RepeatedField<RogueViewGroup>();
	}
}
