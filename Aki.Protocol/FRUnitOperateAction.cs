using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000662 RID: 1634
	public sealed class FRUnitOperateAction : IMessage<FRUnitOperateAction>, IMessage, IEquatable<FRUnitOperateAction>, IDeepCloneable<FRUnitOperateAction>, IBufferMessage
	{
		// Token: 0x060095F1 RID: 38385 RVA: 0x00169BB9 File Offset: 0x00167DB9
		[NullableContext(1)]
		public static FRUnitOperateAction Create()
		{
			return new FRUnitOperateAction();
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x060095F2 RID: 38386 RVA: 0x00169BC0 File Offset: 0x00167DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitOperateAction> Parser
		{
			get
			{
				return FRUnitOperateAction._parser;
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x060095F3 RID: 38387 RVA: 0x00169BC7 File Offset: 0x00167DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x00169BCA File Offset: 0x00167DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateAction.Descriptor;
			}
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00169BD1 File Offset: 0x00167DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction()
		{
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00169BDC File Offset: 0x00167DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction(FRUnitOperateAction other) : this()
		{
			this.opType_ = other.opType_;
			this.unitType_ = other.unitType_;
			this.phantom_ = ((other.phantom_ != null) ? other.phantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x00169C34 File Offset: 0x00167E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateAction Clone()
		{
			return new FRUnitOperateAction(this);
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x060095F8 RID: 38392 RVA: 0x00169C3C File Offset: 0x00167E3C
		// (set) Token: 0x060095F9 RID: 38393 RVA: 0x00169C44 File Offset: 0x00167E44
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

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x060095FA RID: 38394 RVA: 0x00169C4D File Offset: 0x00167E4D
		// (set) Token: 0x060095FB RID: 38395 RVA: 0x00169C55 File Offset: 0x00167E55
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x00169C5E File Offset: 0x00167E5E
		// (set) Token: 0x060095FD RID: 38397 RVA: 0x00169C66 File Offset: 0x00167E66
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

		// Token: 0x060095FE RID: 38398 RVA: 0x00169C6F File Offset: 0x00167E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateAction);
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x00169C80 File Offset: 0x00167E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateAction other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.UnitType == other.UnitType && object.Equals(this.Phantom, other.Phantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00169CE0 File Offset: 0x00167EE0
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

		// Token: 0x06009601 RID: 38401 RVA: 0x00169D5A File Offset: 0x00167F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x00169D67 File Offset: 0x00167F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009603 RID: 38403 RVA: 0x00169D70 File Offset: 0x00167F70
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

		// Token: 0x06009604 RID: 38404 RVA: 0x00169DE4 File Offset: 0x00167FE4
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

		// Token: 0x06009605 RID: 38405 RVA: 0x00169E54 File Offset: 0x00168054
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

		// Token: 0x06009606 RID: 38406 RVA: 0x00169ED0 File Offset: 0x001680D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x00169EDC File Offset: 0x001680DC
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

		// Token: 0x04004787 RID: 18311
		private static readonly MessageParser<FRUnitOperateAction> _parser = new MessageParser<FRUnitOperateAction>(() => new FRUnitOperateAction());

		// Token: 0x04004788 RID: 18312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004789 RID: 18313
		public const int OpTypeFieldNumber = 1;

		// Token: 0x0400478A RID: 18314
		private FRUnitOperate opType_;

		// Token: 0x0400478B RID: 18315
		public const int UnitTypeFieldNumber = 2;

		// Token: 0x0400478C RID: 18316
		private FloroRanchActionUnitType unitType_;

		// Token: 0x0400478D RID: 18317
		public const int PhantomFieldNumber = 3;

		// Token: 0x0400478E RID: 18318
		private FloroRanchPlayUnit phantom_;
	}
}
