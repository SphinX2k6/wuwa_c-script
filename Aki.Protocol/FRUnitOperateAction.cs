using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064E RID: 1614
	public sealed class FRUnitOperateAction : IMessage<FRUnitOperateAction>, IMessage, IEquatable<FRUnitOperateAction>, IDeepCloneable<FRUnitOperateAction>, IBufferMessage
	{
		// Token: 0x0600949B RID: 38043 RVA: 0x0016718D File Offset: 0x0016538D
		[NullableContext(1)]
		public static FRUnitOperateAction Create()
		{
			return new FRUnitOperateAction();
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x0600949C RID: 38044 RVA: 0x00167194 File Offset: 0x00165394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitOperateAction> Parser
		{
			get
			{
				return FRUnitOperateAction._parser;
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x0016719B File Offset: 0x0016539B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600949E RID: 38046 RVA: 0x0016719E File Offset: 0x0016539E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateAction.Descriptor;
			}
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x001671A5 File Offset: 0x001653A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction()
		{
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x001671B0 File Offset: 0x001653B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction(FRUnitOperateAction other) : this()
		{
			this.opType_ = other.opType_;
			this.unitType_ = other.unitType_;
			this.phantom_ = ((other.phantom_ != null) ? other.phantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00167208 File Offset: 0x00165408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction Clone()
		{
			return new FRUnitOperateAction(this);
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x060094A2 RID: 38050 RVA: 0x00167210 File Offset: 0x00165410
		// (set) Token: 0x060094A3 RID: 38051 RVA: 0x00167218 File Offset: 0x00165418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperate OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x060094A4 RID: 38052 RVA: 0x00167221 File Offset: 0x00165421
		// (set) Token: 0x060094A5 RID: 38053 RVA: 0x00167229 File Offset: 0x00165429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActionUnitType UnitType
		{
			get
			{
				return this.unitType_;
			}
			set
			{
				this.unitType_ = value;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x00167232 File Offset: 0x00165432
		// (set) Token: 0x060094A7 RID: 38055 RVA: 0x0016723A File Offset: 0x0016543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Phantom
		{
			get
			{
				return this.phantom_;
			}
			set
			{
				this.phantom_ = value;
			}
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00167243 File Offset: 0x00165443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateAction);
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00167254 File Offset: 0x00165454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateAction other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.UnitType == other.UnitType && object.Equals(this.Phantom, other.Phantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x001672B4 File Offset: 0x001654B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != FRUnitOperate.UnitOpAdd)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.UnitType != FloroRanchActionUnitType.Terrain)
			{
				num ^= this.UnitType.GetHashCode();
			}
			if (this.phantom_ != null)
			{
				num ^= this.Phantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x0016732E File Offset: 0x0016552E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x0016733B File Offset: 0x0016553B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00167344 File Offset: 0x00165544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType != FRUnitOperate.UnitOpAdd)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.OpType);
			}
			if (this.UnitType != FloroRanchActionUnitType.Terrain)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.UnitType);
			}
			if (this.phantom_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x001673B8 File Offset: 0x001655B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != FRUnitOperate.UnitOpAdd)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this.UnitType != FloroRanchActionUnitType.Terrain)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UnitType);
			}
			if (this.phantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x00167428 File Offset: 0x00165628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitOperateAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != FRUnitOperate.UnitOpAdd)
			{
				this.OpType = other.OpType;
			}
			if (other.UnitType != FloroRanchActionUnitType.Terrain)
			{
				this.UnitType = other.UnitType;
			}
			if (other.phantom_ != null)
			{
				if (this.phantom_ == null)
				{
					this.Phantom = new FloroRanchPlayUnit();
				}
				this.Phantom.MergeFrom(other.Phantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x001674A4 File Offset: 0x001656A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x001674B0 File Offset: 0x001656B0
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.phantom_ == null)
							{
								this.Phantom = new FloroRanchPlayUnit();
							}
							input.ReadMessage(this.Phantom);
						}
					}
					else
					{
						this.UnitType = (FloroRanchActionUnitType)input.ReadEnum();
					}
				}
				else
				{
					this.OpType = (FRUnitOperate)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004780 RID: 18304
		private static readonly MessageParser<FRUnitOperateAction> _parser = new MessageParser<FRUnitOperateAction>(() => new FRUnitOperateAction());

		// Token: 0x04004781 RID: 18305
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004782 RID: 18306
		public const int OpTypeFieldNumber = 1;

		// Token: 0x04004783 RID: 18307
		private FRUnitOperate opType_;

		// Token: 0x04004784 RID: 18308
		public const int UnitTypeFieldNumber = 2;

		// Token: 0x04004785 RID: 18309
		private FloroRanchActionUnitType unitType_;

		// Token: 0x04004786 RID: 18310
		public const int PhantomFieldNumber = 3;

		// Token: 0x04004787 RID: 18311
		private FloroRanchPlayUnit phantom_;
	}
}
