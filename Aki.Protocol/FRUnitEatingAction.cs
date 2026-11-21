using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064C RID: 1612
	public sealed class FRUnitEatingAction : IMessage<FRUnitEatingAction>, IMessage, IEquatable<FRUnitEatingAction>, IDeepCloneable<FRUnitEatingAction>, IBufferMessage
	{
		// Token: 0x06009472 RID: 38002 RVA: 0x00166BF5 File Offset: 0x00164DF5
		[NullableContext(1)]
		public static FRUnitEatingAction Create()
		{
			return new FRUnitEatingAction();
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x00166BFC File Offset: 0x00164DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitEatingAction> Parser
		{
			get
			{
				return FRUnitEatingAction._parser;
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06009474 RID: 38004 RVA: 0x00166C03 File Offset: 0x00164E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06009475 RID: 38005 RVA: 0x00166C06 File Offset: 0x00164E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitEatingAction.Descriptor;
			}
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x00166C0D File Offset: 0x00164E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction()
		{
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x00166C20 File Offset: 0x00164E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction(FRUnitEatingAction other) : this()
		{
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this.resourcesChange_ = ((other.resourcesChange_ != null) ? other.resourcesChange_.Clone() : null);
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009478 RID: 38008 RVA: 0x00166C7D File Offset: 0x00164E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction Clone()
		{
			return new FRUnitEatingAction(this);
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x00166C85 File Offset: 0x00164E85
		// (set) Token: 0x0600947A RID: 38010 RVA: 0x00166C8D File Offset: 0x00164E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUnitIncId
		{
			get
			{
				return this.targetUnitIncId_;
			}
			set
			{
				this.targetUnitIncId_ = value;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x0600947B RID: 38011 RVA: 0x00166C96 File Offset: 0x00164E96
		// (set) Token: 0x0600947C RID: 38012 RVA: 0x00166C9E File Offset: 0x00164E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction ResourcesChange
		{
			get
			{
				return this.resourcesChange_;
			}
			set
			{
				this.resourcesChange_ = value;
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600947D RID: 38013 RVA: 0x00166CA7 File Offset: 0x00164EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00166CAF File Offset: 0x00164EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitEatingAction);
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00166CC0 File Offset: 0x00164EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitEatingAction other)
		{
			return other != null && (other == this || (this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this.ResourcesChange, other.ResourcesChange) && this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00166D24 File Offset: 0x00164F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUnitIncId != 0)
			{
				num ^= this.TargetUnitIncId.GetHashCode();
			}
			if (this.resourcesChange_ != null)
			{
				num ^= this.ResourcesChange.GetHashCode();
			}
			num ^= this.actions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00166D87 File Offset: 0x00164F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x00166D94 File Offset: 0x00164F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x00166DA0 File Offset: 0x00164FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUnitIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetUnitIncId);
			}
			if (this.resourcesChange_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ResourcesChange);
			}
			this.actions_.WriteTo(ref output, FRUnitEatingAction._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x00166E0C File Offset: 0x0016500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUnitIncId);
			}
			if (this.resourcesChange_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResourcesChange);
			}
			num += this.actions_.CalculateSize(FRUnitEatingAction._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x00166E78 File Offset: 0x00165078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitEatingAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUnitIncId != 0)
			{
				this.TargetUnitIncId = other.TargetUnitIncId;
			}
			if (other.resourcesChange_ != null)
			{
				if (this.resourcesChange_ == null)
				{
					this.ResourcesChange = new FRUnitResourcesChangeAction();
				}
				this.ResourcesChange.MergeFrom(other.ResourcesChange);
			}
			this.actions_.Add(other.actions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00166EF1 File Offset: 0x001650F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x00166EFC File Offset: 0x001650FC
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.actions_.AddEntriesFrom(ref input, FRUnitEatingAction._repeated_actions_codec);
						}
					}
					else
					{
						if (this.resourcesChange_ == null)
						{
							this.ResourcesChange = new FRUnitResourcesChangeAction();
						}
						input.ReadMessage(this.ResourcesChange);
					}
				}
				else
				{
					this.TargetUnitIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004773 RID: 18291
		private static readonly MessageParser<FRUnitEatingAction> _parser = new MessageParser<FRUnitEatingAction>(() => new FRUnitEatingAction());

		// Token: 0x04004774 RID: 18292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004775 RID: 18293
		public const int TargetUnitIncIdFieldNumber = 1;

		// Token: 0x04004776 RID: 18294
		private int targetUnitIncId_;

		// Token: 0x04004777 RID: 18295
		public const int ResourcesChangeFieldNumber = 2;

		// Token: 0x04004778 RID: 18296
		private FRUnitResourcesChangeAction resourcesChange_;

		// Token: 0x04004779 RID: 18297
		public const int ActionsFieldNumber = 3;

		// Token: 0x0400477A RID: 18298
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_actions_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(26U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x0400477B RID: 18299
		private readonly RepeatedField<FloroRanchUnitActionMsg> actions_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
