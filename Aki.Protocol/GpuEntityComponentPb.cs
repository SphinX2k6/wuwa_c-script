using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F4 RID: 1780
	public sealed class GpuEntityComponentPb : IMessage<GpuEntityComponentPb>, IMessage, IEquatable<GpuEntityComponentPb>, IDeepCloneable<GpuEntityComponentPb>, IBufferMessage
	{
		// Token: 0x0600A284 RID: 41604 RVA: 0x001893E2 File Offset: 0x001875E2
		[NullableContext(1)]
		public static GpuEntityComponentPb Create()
		{
			return new GpuEntityComponentPb();
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x001893E9 File Offset: 0x001875E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x001893EC File Offset: 0x001875EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuEntityComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x001893F3 File Offset: 0x001875F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb()
		{
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x001893FC File Offset: 0x001875FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb(GpuEntityComponentPb other) : this()
		{
			this.configId_ = other.configId_;
			GpuEntityComponentPb.DataOneofCase dataCase = other.DataCase;
			if (dataCase != GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
			{
				if (dataCase == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
				{
					this.GpuRolePbEntityData = other.GpuRolePbEntityData.Clone();
				}
			}
			else
			{
				this.GpuMonsterEntityPbData = other.GpuMonsterEntityPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x00189461 File Offset: 0x00187661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb Clone()
		{
			return new GpuEntityComponentPb(this);
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600A28A RID: 41610 RVA: 0x00189469 File Offset: 0x00187669
		// (set) Token: 0x0600A28B RID: 41611 RVA: 0x00189471 File Offset: 0x00187671
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600A28C RID: 41612 RVA: 0x0018947A File Offset: 0x0018767A
		// (set) Token: 0x0600A28D RID: 41613 RVA: 0x00189492 File Offset: 0x00187692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData GpuMonsterEntityPbData
		{
			get
			{
				if (this.dataCase_ != GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
				{
					return null;
				}
				return (GpuMonsterEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? GpuEntityComponentPb.DataOneofCase.None : GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData);
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600A28E RID: 41614 RVA: 0x001894A8 File Offset: 0x001876A8
		// (set) Token: 0x0600A28F RID: 41615 RVA: 0x001894C0 File Offset: 0x001876C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData GpuRolePbEntityData
		{
			get
			{
				if (this.dataCase_ != GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
				{
					return null;
				}
				return (GpuRoleEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? GpuEntityComponentPb.DataOneofCase.None : GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData);
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600A290 RID: 41616 RVA: 0x001894D6 File Offset: 0x001876D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x001894DE File Offset: 0x001876DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = GpuEntityComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x001894EE File Offset: 0x001876EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuEntityComponentPb);
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x001894FC File Offset: 0x001876FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuEntityComponentPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.GpuMonsterEntityPbData, other.GpuMonsterEntityPbData) && object.Equals(this.GpuRolePbEntityData, other.GpuRolePbEntityData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x00189570 File Offset: 0x00187770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
			{
				num ^= this.GpuMonsterEntityPbData.GetHashCode();
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
			{
				num ^= this.GpuRolePbEntityData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x001895E6 File Offset: 0x001877E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x001895F3 File Offset: 0x001877F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x001895FC File Offset: 0x001877FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GpuMonsterEntityPbData);
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GpuRolePbEntityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00189674 File Offset: 0x00187874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GpuMonsterEntityPbData);
			}
			if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GpuRolePbEntityData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x001896E4 File Offset: 0x001878E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GpuEntityComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			GpuEntityComponentPb.DataOneofCase dataCase = other.DataCase;
			if (dataCase != GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
			{
				if (dataCase == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
				{
					if (this.GpuRolePbEntityData == null)
					{
						this.GpuRolePbEntityData = new GpuRoleEntityPbData();
					}
					this.GpuRolePbEntityData.MergeFrom(other.GpuRolePbEntityData);
				}
			}
			else
			{
				if (this.GpuMonsterEntityPbData == null)
				{
					this.GpuMonsterEntityPbData = new GpuMonsterEntityPbData();
				}
				this.GpuMonsterEntityPbData.MergeFrom(other.GpuMonsterEntityPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x0018977B File Offset: 0x0018797B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00189784 File Offset: 0x00187984
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
							GpuRoleEntityPbData gpuRoleEntityPbData = new GpuRoleEntityPbData();
							if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuRolePbEntityData)
							{
								gpuRoleEntityPbData.MergeFrom(this.GpuRolePbEntityData);
							}
							input.ReadMessage(gpuRoleEntityPbData);
							this.GpuRolePbEntityData = gpuRoleEntityPbData;
						}
					}
					else
					{
						GpuMonsterEntityPbData gpuMonsterEntityPbData = new GpuMonsterEntityPbData();
						if (this.dataCase_ == GpuEntityComponentPb.DataOneofCase.GpuMonsterEntityPbData)
						{
							gpuMonsterEntityPbData.MergeFrom(this.GpuMonsterEntityPbData);
						}
						input.ReadMessage(gpuMonsterEntityPbData);
						this.GpuMonsterEntityPbData = gpuMonsterEntityPbData;
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004BA9 RID: 19369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BAA RID: 19370
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04004BAB RID: 19371
		private int configId_;

		// Token: 0x04004BAC RID: 19372
		public const int GpuMonsterEntityPbDataFieldNumber = 2;

		// Token: 0x04004BAD RID: 19373
		public const int GpuRolePbEntityDataFieldNumber = 3;

		// Token: 0x04004BAE RID: 19374
		private object data_;

		// Token: 0x04004BAF RID: 19375
		private GpuEntityComponentPb.DataOneofCase dataCase_;

		// Token: 0x02001853 RID: 6227
		public enum DataOneofCase
		{
			// Token: 0x0400CC9E RID: 52382
			None,
			// Token: 0x0400CC9F RID: 52383
			GpuMonsterEntityPbData = 2,
			// Token: 0x0400CCA0 RID: 52384
			GpuRolePbEntityData
		}
	}
}
