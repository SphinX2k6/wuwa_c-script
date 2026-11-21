using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001100 RID: 4352
	[NetMessage(EMessageId.RoleTrainRequest)]
	public sealed class RoleTrainRequest : IMessage<RoleTrainRequest>, IMessage, IEquatable<RoleTrainRequest>, IDeepCloneable<RoleTrainRequest>, IBufferMessage
	{
		// Token: 0x0601743E RID: 95294 RVA: 0x00362CCD File Offset: 0x00360ECD
		[NullableContext(1)]
		public static RoleTrainRequest Create()
		{
			return new RoleTrainRequest();
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x0601743F RID: 95295 RVA: 0x00362CD4 File Offset: 0x00360ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x06017440 RID: 95296 RVA: 0x00362CD7 File Offset: 0x00360ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrainRequest.Descriptor;
			}
		}

		// Token: 0x06017441 RID: 95297 RVA: 0x00362CDE File Offset: 0x00360EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest()
		{
		}

		// Token: 0x06017442 RID: 95298 RVA: 0x00362CE6 File Offset: 0x00360EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest(RoleTrainRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.trainType_ = other.trainType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017443 RID: 95299 RVA: 0x00362D17 File Offset: 0x00360F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainRequest Clone()
		{
			return new RoleTrainRequest(this);
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x06017444 RID: 95300 RVA: 0x00362D1F File Offset: 0x00360F1F
		// (set) Token: 0x06017445 RID: 95301 RVA: 0x00362D27 File Offset: 0x00360F27
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

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x06017446 RID: 95302 RVA: 0x00362D30 File Offset: 0x00360F30
		// (set) Token: 0x06017447 RID: 95303 RVA: 0x00362D38 File Offset: 0x00360F38
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

		// Token: 0x06017448 RID: 95304 RVA: 0x00362D41 File Offset: 0x00360F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrainRequest);
		}

		// Token: 0x06017449 RID: 95305 RVA: 0x00362D4F File Offset: 0x00360F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrainRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.TrainType == other.TrainType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601744A RID: 95306 RVA: 0x00362D90 File Offset: 0x00360F90
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

		// Token: 0x0601744B RID: 95307 RVA: 0x00362DE8 File Offset: 0x00360FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x00362DF5 File Offset: 0x00360FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601744D RID: 95309 RVA: 0x00362E00 File Offset: 0x00361000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrainType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TrainType);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x00362E5C File Offset: 0x0036105C
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

		// Token: 0x0601744F RID: 95311 RVA: 0x00362EB4 File Offset: 0x003610B4
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

		// Token: 0x06017450 RID: 95312 RVA: 0x00362F04 File Offset: 0x00361104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017451 RID: 95313 RVA: 0x00362F10 File Offset: 0x00361110
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
				if (num != 32U)
				{
					if (num != 56U)
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

		// Token: 0x04008B1C RID: 35612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B1D RID: 35613
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04008B1E RID: 35614
		private int roleId_;

		// Token: 0x04008B1F RID: 35615
		public const int TrainTypeFieldNumber = 4;

		// Token: 0x04008B20 RID: 35616
		private int trainType_;
	}
}
