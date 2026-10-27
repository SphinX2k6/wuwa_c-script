using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C6 RID: 4294
	[NetMessage(EMessageId.RoleTrainRequest)]
	public sealed class RoleTrainRequest : IMessage<RoleTrainRequest>, IMessage, IEquatable<RoleTrainRequest>, IDeepCloneable<RoleTrainRequest>, IBufferMessage
	{
		// Token: 0x06016E9F RID: 93855 RVA: 0x00353A14 File Offset: 0x00351C14
		[NullableContext(1)]
		public static RoleTrainRequest Create()
		{
			return new RoleTrainRequest();
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x06016EA0 RID: 93856 RVA: 0x00353A1B File Offset: 0x00351C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06016EA1 RID: 93857 RVA: 0x00353A1E File Offset: 0x00351C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrainRequest.Descriptor;
			}
		}

		// Token: 0x06016EA2 RID: 93858 RVA: 0x00353A25 File Offset: 0x00351C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest()
		{
		}

		// Token: 0x06016EA3 RID: 93859 RVA: 0x00353A2D File Offset: 0x00351C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest(RoleTrainRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.trainType_ = other.trainType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EA4 RID: 93860 RVA: 0x00353A5E File Offset: 0x00351C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest Clone()
		{
			return new RoleTrainRequest(this);
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06016EA5 RID: 93861 RVA: 0x00353A66 File Offset: 0x00351C66
		// (set) Token: 0x06016EA6 RID: 93862 RVA: 0x00353A6E File Offset: 0x00351C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06016EA7 RID: 93863 RVA: 0x00353A77 File Offset: 0x00351C77
		// (set) Token: 0x06016EA8 RID: 93864 RVA: 0x00353A7F File Offset: 0x00351C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrainType
		{
			get
			{
				return this.trainType_;
			}
			set
			{
				this.trainType_ = value;
			}
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x00353A88 File Offset: 0x00351C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrainRequest);
		}

		// Token: 0x06016EAA RID: 93866 RVA: 0x00353A96 File Offset: 0x00351C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrainRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.TrainType == other.TrainType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EAB RID: 93867 RVA: 0x00353AD4 File Offset: 0x00351CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.TrainType != 0)
			{
				num ^= this.TrainType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x00353B2C File Offset: 0x00351D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x00353B39 File Offset: 0x00351D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x00353B44 File Offset: 0x00351D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrainType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TrainType);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x00353BA0 File Offset: 0x00351DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.TrainType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrainType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x00353BF8 File Offset: 0x00351DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.TrainType != 0)
			{
				this.TrainType = other.TrainType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EB1 RID: 93873 RVA: 0x00353C48 File Offset: 0x00351E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EB2 RID: 93874 RVA: 0x00353C54 File Offset: 0x00351E54
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.TrainType = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400888B RID: 34955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400888C RID: 34956
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400888D RID: 34957
		private int roleId_;

		// Token: 0x0400888E RID: 34958
		public const int TrainTypeFieldNumber = 5;

		// Token: 0x0400888F RID: 34959
		private int trainType_;
	}
}
