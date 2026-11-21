using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC3 RID: 4035
	public sealed class RogueResComplex : IMessage<RogueResComplex>, IMessage, IEquatable<RogueResComplex>, IDeepCloneable<RogueResComplex>, IBufferMessage
	{
		// Token: 0x0601598D RID: 88461 RVA: 0x0032314F File Offset: 0x0032134F
		[NullableContext(1)]
		public static RogueResComplex Create()
		{
			return new RogueResComplex();
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0601598E RID: 88462 RVA: 0x00323156 File Offset: 0x00321356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x0601598F RID: 88463 RVA: 0x00323159 File Offset: 0x00321359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResComplex.Descriptor;
			}
		}

		// Token: 0x06015990 RID: 88464 RVA: 0x00323160 File Offset: 0x00321360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex()
		{
		}

		// Token: 0x06015991 RID: 88465 RVA: 0x00323168 File Offset: 0x00321368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex(RogueResComplex other) : this()
		{
			this.configId_ = other.configId_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.isSelect_ = other.isSelect_;
			this.isRole_ = other.isRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015992 RID: 88466 RVA: 0x003231C8 File Offset: 0x003213C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex Clone()
		{
			return new RogueResComplex(this);
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x06015993 RID: 88467 RVA: 0x003231D0 File Offset: 0x003213D0
		// (set) Token: 0x06015994 RID: 88468 RVA: 0x003231D8 File Offset: 0x003213D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x06015995 RID: 88469 RVA: 0x003231E1 File Offset: 0x003213E1
		// (set) Token: 0x06015996 RID: 88470 RVA: 0x003231E9 File Offset: 0x003213E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x06015997 RID: 88471 RVA: 0x003231F2 File Offset: 0x003213F2
		// (set) Token: 0x06015998 RID: 88472 RVA: 0x003231FA File Offset: 0x003213FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x06015999 RID: 88473 RVA: 0x00323203 File Offset: 0x00321403
		// (set) Token: 0x0601599A RID: 88474 RVA: 0x0032320B File Offset: 0x0032140B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0601599B RID: 88475 RVA: 0x00323214 File Offset: 0x00321414
		// (set) Token: 0x0601599C RID: 88476 RVA: 0x0032321C File Offset: 0x0032141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRole
		{
			get
			{
				return this.isRole_;
			}
			set
			{
				this.isRole_ = value;
			}
		}

		// Token: 0x0601599D RID: 88477 RVA: 0x00323225 File Offset: 0x00321425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResComplex);
		}

		// Token: 0x0601599E RID: 88478 RVA: 0x00323234 File Offset: 0x00321434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResComplex other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.ItemId == other.ItemId && this.Count == other.Count && this.IsSelect == other.IsSelect && this.IsRole == other.IsRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601599F RID: 88479 RVA: 0x003232B0 File Offset: 0x003214B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.IsRole)
			{
				num ^= this.IsRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159A0 RID: 88480 RVA: 0x00323353 File Offset: 0x00321553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159A1 RID: 88481 RVA: 0x00323360 File Offset: 0x00321560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159A2 RID: 88482 RVA: 0x0032336C File Offset: 0x0032156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSelect);
			}
			if (this.IsRole)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159A3 RID: 88483 RVA: 0x00323418 File Offset: 0x00321618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this.IsRole)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159A4 RID: 88484 RVA: 0x003234A0 File Offset: 0x003216A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResComplex other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.IsRole)
			{
				this.IsRole = other.IsRole;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159A5 RID: 88485 RVA: 0x0032352C File Offset: 0x0032172C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159A6 RID: 88486 RVA: 0x00323538 File Offset: 0x00321738
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsRole = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008226 RID: 33318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008227 RID: 33319
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008228 RID: 33320
		private int configId_;

		// Token: 0x04008229 RID: 33321
		public const int ItemIdFieldNumber = 2;

		// Token: 0x0400822A RID: 33322
		private int itemId_;

		// Token: 0x0400822B RID: 33323
		public const int CountFieldNumber = 3;

		// Token: 0x0400822C RID: 33324
		private int count_;

		// Token: 0x0400822D RID: 33325
		public const int IsSelectFieldNumber = 4;

		// Token: 0x0400822E RID: 33326
		private bool isSelect_;

		// Token: 0x0400822F RID: 33327
		public const int IsRoleFieldNumber = 5;

		// Token: 0x04008230 RID: 33328
		private bool isRole_;
	}
}
