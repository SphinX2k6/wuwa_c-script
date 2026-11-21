using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6F RID: 2927
	public sealed class OccupiedBoardGridInfo : IMessage<OccupiedBoardGridInfo>, IMessage, IEquatable<OccupiedBoardGridInfo>, IDeepCloneable<OccupiedBoardGridInfo>, IBufferMessage
	{
		// Token: 0x0600FE0E RID: 65038 RVA: 0x002513F3 File Offset: 0x0024F5F3
		[NullableContext(1)]
		public static OccupiedBoardGridInfo Create()
		{
			return new OccupiedBoardGridInfo();
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600FE0F RID: 65039 RVA: 0x002513FA File Offset: 0x0024F5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OccupiedBoardGridInfo> Parser
		{
			get
			{
				return OccupiedBoardGridInfo._parser;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600FE10 RID: 65040 RVA: 0x00251401 File Offset: 0x0024F601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600FE11 RID: 65041 RVA: 0x00251404 File Offset: 0x0024F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupiedBoardGridInfo.Descriptor;
			}
		}

		// Token: 0x0600FE12 RID: 65042 RVA: 0x0025140B File Offset: 0x0024F60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo()
		{
		}

		// Token: 0x0600FE13 RID: 65043 RVA: 0x00251414 File Offset: 0x0024F614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo(OccupiedBoardGridInfo other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.occupyingEntityConfigId_ = other.occupyingEntityConfigId_;
			this.entityConfigType_ = other.entityConfigType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE14 RID: 65044 RVA: 0x0025146C File Offset: 0x0024F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo Clone()
		{
			return new OccupiedBoardGridInfo(this);
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600FE15 RID: 65045 RVA: 0x00251474 File Offset: 0x0024F674
		// (set) Token: 0x0600FE16 RID: 65046 RVA: 0x0025147C File Offset: 0x0024F67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600FE17 RID: 65047 RVA: 0x00251485 File Offset: 0x0024F685
		// (set) Token: 0x0600FE18 RID: 65048 RVA: 0x0025148D File Offset: 0x0024F68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OccupyingEntityConfigId
		{
			get
			{
				return this.occupyingEntityConfigId_;
			}
			set
			{
				this.occupyingEntityConfigId_ = value;
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600FE19 RID: 65049 RVA: 0x00251496 File Offset: 0x0024F696
		// (set) Token: 0x0600FE1A RID: 65050 RVA: 0x0025149E File Offset: 0x0024F69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigType
		{
			get
			{
				return this.entityConfigType_;
			}
			set
			{
				this.entityConfigType_ = value;
			}
		}

		// Token: 0x0600FE1B RID: 65051 RVA: 0x002514A7 File Offset: 0x0024F6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupiedBoardGridInfo);
		}

		// Token: 0x0600FE1C RID: 65052 RVA: 0x002514B8 File Offset: 0x0024F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupiedBoardGridInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && this.OccupyingEntityConfigId == other.OccupyingEntityConfigId && this.EntityConfigType == other.EntityConfigType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE1D RID: 65053 RVA: 0x00251518 File Offset: 0x0024F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				num ^= this.OccupyingEntityConfigId.GetHashCode();
			}
			if (this.EntityConfigType != 0)
			{
				num ^= this.EntityConfigType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE1E RID: 65054 RVA: 0x00251586 File Offset: 0x0024F786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE1F RID: 65055 RVA: 0x00251593 File Offset: 0x0024F793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE20 RID: 65056 RVA: 0x0025159C File Offset: 0x0024F79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OccupyingEntityConfigId);
			}
			if (this.EntityConfigType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntityConfigType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE21 RID: 65057 RVA: 0x00251614 File Offset: 0x0024F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OccupyingEntityConfigId);
			}
			if (this.EntityConfigType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE22 RID: 65058 RVA: 0x00251684 File Offset: 0x0024F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupiedBoardGridInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new BoardGridPositionInfo();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.OccupyingEntityConfigId != 0)
			{
				this.OccupyingEntityConfigId = other.OccupyingEntityConfigId;
			}
			if (other.EntityConfigType != 0)
			{
				this.EntityConfigType = other.EntityConfigType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE23 RID: 65059 RVA: 0x00251700 File Offset: 0x0024F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE24 RID: 65060 RVA: 0x0025170C File Offset: 0x0024F90C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityConfigType = input.ReadInt32();
						}
					}
					else
					{
						this.OccupyingEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new BoardGridPositionInfo();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x040065AC RID: 26028
		private static readonly MessageParser<OccupiedBoardGridInfo> _parser = new MessageParser<OccupiedBoardGridInfo>(() => new OccupiedBoardGridInfo());

		// Token: 0x040065AD RID: 26029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065AE RID: 26030
		public const int PosFieldNumber = 1;

		// Token: 0x040065AF RID: 26031
		private BoardGridPositionInfo pos_;

		// Token: 0x040065B0 RID: 26032
		public const int OccupyingEntityConfigIdFieldNumber = 2;

		// Token: 0x040065B1 RID: 26033
		private int occupyingEntityConfigId_;

		// Token: 0x040065B2 RID: 26034
		public const int EntityConfigTypeFieldNumber = 3;

		// Token: 0x040065B3 RID: 26035
		private int entityConfigType_;
	}
}
