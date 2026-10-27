using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000660 RID: 1632
	public sealed class FRUnitEatingAction : IMessage<FRUnitEatingAction>, IMessage, IEquatable<FRUnitEatingAction>, IDeepCloneable<FRUnitEatingAction>, IBufferMessage
	{
		// Token: 0x060095C8 RID: 38344 RVA: 0x00169621 File Offset: 0x00167821
		[NullableContext(1)]
		public static FRUnitEatingAction Create()
		{
			return new FRUnitEatingAction();
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060095C9 RID: 38345 RVA: 0x00169628 File Offset: 0x00167828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitEatingAction> Parser
		{
			get
			{
				return FRUnitEatingAction._parser;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060095CA RID: 38346 RVA: 0x0016962F File Offset: 0x0016782F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x00169632 File Offset: 0x00167832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitEatingAction.Descriptor;
			}
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x00169639 File Offset: 0x00167839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction()
		{
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x0016964C File Offset: 0x0016784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction(FRUnitEatingAction other) : this()
		{
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this.resourcesChange_ = ((other.resourcesChange_ != null) ? other.resourcesChange_.Clone() : null);
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x001696A9 File Offset: 0x001678A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingAction Clone()
		{
			return new FRUnitEatingAction(this);
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x001696B1 File Offset: 0x001678B1
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x001696B9 File Offset: 0x001678B9
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x001696C2 File Offset: 0x001678C2
		// (set) Token: 0x060095D2 RID: 38354 RVA: 0x001696CA File Offset: 0x001678CA
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

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060095D3 RID: 38355 RVA: 0x001696D3 File Offset: 0x001678D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x001696DB File Offset: 0x001678DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitEatingAction);
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x001696EC File Offset: 0x001678EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitEatingAction other)
		{
			return other != null && (other == this || (this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this.ResourcesChange, other.ResourcesChange) && this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x00169750 File Offset: 0x00167950
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

		// Token: 0x060095D7 RID: 38359 RVA: 0x001697B3 File Offset: 0x001679B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x001697C0 File Offset: 0x001679C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x001697CC File Offset: 0x001679CC
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

		// Token: 0x060095DA RID: 38362 RVA: 0x00169838 File Offset: 0x00167A38
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

		// Token: 0x060095DB RID: 38363 RVA: 0x001698A4 File Offset: 0x00167AA4
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

		// Token: 0x060095DC RID: 38364 RVA: 0x0016991D File Offset: 0x00167B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x00169928 File Offset: 0x00167B28
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

		// Token: 0x0400477A RID: 18298
		private static readonly MessageParser<FRUnitEatingAction> _parser = new MessageParser<FRUnitEatingAction>(() => new FRUnitEatingAction());

		// Token: 0x0400477B RID: 18299
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400477C RID: 18300
		public const int TargetUnitIncIdFieldNumber = 1;

		// Token: 0x0400477D RID: 18301
		private int targetUnitIncId_;

		// Token: 0x0400477E RID: 18302
		public const int ResourcesChangeFieldNumber = 2;

		// Token: 0x0400477F RID: 18303
		private FRUnitResourcesChangeAction resourcesChange_;

		// Token: 0x04004780 RID: 18304
		public const int ActionsFieldNumber = 3;

		// Token: 0x04004781 RID: 18305
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_actions_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(26U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x04004782 RID: 18306
		private readonly RepeatedField<FloroRanchUnitActionMsg> actions_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
