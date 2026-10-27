using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000708 RID: 1800
	public sealed class GpuEntityComponentPb : IMessage<GpuEntityComponentPb>, IMessage, IEquatable<GpuEntityComponentPb>, IDeepCloneable<GpuEntityComponentPb>, IBufferMessage
	{
		// Token: 0x0600A3DA RID: 41946 RVA: 0x0018BE16 File Offset: 0x0018A016
		[NullableContext(1)]
		public static GpuEntityComponentPb Create()
		{
			return new GpuEntityComponentPb();
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600A3DB RID: 41947 RVA: 0x0018BE1D File Offset: 0x0018A01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x0018BE20 File Offset: 0x0018A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuEntityComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x0018BE27 File Offset: 0x0018A027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb()
		{
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x0018BE30 File Offset: 0x0018A030
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

		// Token: 0x0600A3DF RID: 41951 RVA: 0x0018BE95 File Offset: 0x0018A095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb Clone()
		{
			return new GpuEntityComponentPb(this);
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600A3E0 RID: 41952 RVA: 0x0018BE9D File Offset: 0x0018A09D
		// (set) Token: 0x0600A3E1 RID: 41953 RVA: 0x0018BEA5 File Offset: 0x0018A0A5
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

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600A3E2 RID: 41954 RVA: 0x0018BEAE File Offset: 0x0018A0AE
		// (set) Token: 0x0600A3E3 RID: 41955 RVA: 0x0018BEC6 File Offset: 0x0018A0C6
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

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600A3E4 RID: 41956 RVA: 0x0018BEDC File Offset: 0x0018A0DC
		// (set) Token: 0x0600A3E5 RID: 41957 RVA: 0x0018BEF4 File Offset: 0x0018A0F4
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

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600A3E6 RID: 41958 RVA: 0x0018BF0A File Offset: 0x0018A10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x0018BF12 File Offset: 0x0018A112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = GpuEntityComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x0018BF22 File Offset: 0x0018A122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuEntityComponentPb);
		}

		// Token: 0x0600A3E9 RID: 41961 RVA: 0x0018BF30 File Offset: 0x0018A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuEntityComponentPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.GpuMonsterEntityPbData, other.GpuMonsterEntityPbData) && object.Equals(this.GpuRolePbEntityData, other.GpuRolePbEntityData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x0018BFA4 File Offset: 0x0018A1A4
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

		// Token: 0x0600A3EB RID: 41963 RVA: 0x0018C01A File Offset: 0x0018A21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x0018C027 File Offset: 0x0018A227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x0018C030 File Offset: 0x0018A230
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

		// Token: 0x0600A3EE RID: 41966 RVA: 0x0018C0A8 File Offset: 0x0018A2A8
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

		// Token: 0x0600A3EF RID: 41967 RVA: 0x0018C118 File Offset: 0x0018A318
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

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x0018C1AF File Offset: 0x0018A3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x0018C1B8 File Offset: 0x0018A3B8
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

		// Token: 0x04004BB0 RID: 19376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB1 RID: 19377
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04004BB2 RID: 19378
		private int configId_;

		// Token: 0x04004BB3 RID: 19379
		public const int GpuMonsterEntityPbDataFieldNumber = 2;

		// Token: 0x04004BB4 RID: 19380
		public const int GpuRolePbEntityDataFieldNumber = 3;

		// Token: 0x04004BB5 RID: 19381
		private object data_;

		// Token: 0x04004BB6 RID: 19382
		private GpuEntityComponentPb.DataOneofCase dataCase_;

		// Token: 0x020017DB RID: 6107
		public enum DataOneofCase
		{
			// Token: 0x0400C773 RID: 51059
			None,
			// Token: 0x0400C774 RID: 51060
			GpuMonsterEntityPbData = 2,
			// Token: 0x0400C775 RID: 51061
			GpuRolePbEntityData
		}
	}
}
