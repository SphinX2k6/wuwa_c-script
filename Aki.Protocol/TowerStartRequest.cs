using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CE RID: 5070
	[NetMessage(EMessageId.TowerStartRequest)]
	public sealed class TowerStartRequest : IMessage<TowerStartRequest>, IMessage, IEquatable<TowerStartRequest>, IDeepCloneable<TowerStartRequest>, IBufferMessage
	{
		// Token: 0x0601AE3D RID: 110141 RVA: 0x003E5DE3 File Offset: 0x003E3FE3
		[NullableContext(1)]
		public static TowerStartRequest Create()
		{
			return new TowerStartRequest();
		}

		// Token: 0x17005AAF RID: 23215
		// (get) Token: 0x0601AE3E RID: 110142 RVA: 0x003E5DEA File Offset: 0x003E3FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AB0 RID: 23216
		// (get) Token: 0x0601AE3F RID: 110143 RVA: 0x003E5DED File Offset: 0x003E3FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerStartRequest.Descriptor;
			}
		}

		// Token: 0x0601AE40 RID: 110144 RVA: 0x003E5DF4 File Offset: 0x003E3FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest()
		{
		}

		// Token: 0x0601AE41 RID: 110145 RVA: 0x003E5E07 File Offset: 0x003E4007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest(TowerStartRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this.formation_ = other.formation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE42 RID: 110146 RVA: 0x003E5E3D File Offset: 0x003E403D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest Clone()
		{
			return new TowerStartRequest(this);
		}

		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x0601AE43 RID: 110147 RVA: 0x003E5E45 File Offset: 0x003E4045
		// (set) Token: 0x0601AE44 RID: 110148 RVA: 0x003E5E4D File Offset: 0x003E404D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x0601AE45 RID: 110149 RVA: 0x003E5E56 File Offset: 0x003E4056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRolePb> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x0601AE46 RID: 110150 RVA: 0x003E5E5E File Offset: 0x003E405E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerStartRequest);
		}

		// Token: 0x0601AE47 RID: 110151 RVA: 0x003E5E6C File Offset: 0x003E406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerStartRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && this.formation_.Equals(other.formation_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE48 RID: 110152 RVA: 0x003E5EBC File Offset: 0x003E40BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			num ^= this.formation_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE49 RID: 110153 RVA: 0x003E5F09 File Offset: 0x003E4109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE4A RID: 110154 RVA: 0x003E5F16 File Offset: 0x003E4116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE4B RID: 110155 RVA: 0x003E5F20 File Offset: 0x003E4120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TowerConfigId);
			}
			this.formation_.WriteTo(ref output, TowerStartRequest._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE4C RID: 110156 RVA: 0x003E5F70 File Offset: 0x003E4170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			num += this.formation_.CalculateSize(TowerStartRequest._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE4D RID: 110157 RVA: 0x003E5FC4 File Offset: 0x003E41C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this.formation_.Add(other.formation_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE4E RID: 110158 RVA: 0x003E6011 File Offset: 0x003E4211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE4F RID: 110159 RVA: 0x003E601C File Offset: 0x003E421C
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
				if (num != 72U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formation_.AddEntriesFrom(ref input, TowerStartRequest._repeated_formation_codec);
					}
				}
				else
				{
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009BF8 RID: 39928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BF9 RID: 39929
		public const int TowerConfigIdFieldNumber = 9;

		// Token: 0x04009BFA RID: 39930
		private int towerConfigId_;

		// Token: 0x04009BFB RID: 39931
		public const int FormationFieldNumber = 11;

		// Token: 0x04009BFC RID: 39932
		private static readonly FieldCodec<TowerRolePb> _repeated_formation_codec = FieldCodec.ForMessage<TowerRolePb>(90U, TowerRolePb.Parser);

		// Token: 0x04009BFD RID: 39933
		private readonly RepeatedField<TowerRolePb> formation_ = new RepeatedField<TowerRolePb>();
	}
}
