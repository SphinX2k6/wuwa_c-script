using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B02 RID: 2818
	public sealed class NewbieCarnivalData : IMessage<NewbieCarnivalData>, IMessage, IEquatable<NewbieCarnivalData>, IDeepCloneable<NewbieCarnivalData>, IBufferMessage
	{
		// Token: 0x0600F4EE RID: 62702 RVA: 0x0023BF55 File Offset: 0x0023A155
		[NullableContext(1)]
		public static NewbieCarnivalData Create()
		{
			return new NewbieCarnivalData();
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600F4EF RID: 62703 RVA: 0x0023BF5C File Offset: 0x0023A15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600F4F0 RID: 62704 RVA: 0x0023BF5F File Offset: 0x0023A15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalData.Descriptor;
			}
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x0023BF66 File Offset: 0x0023A166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData()
		{
		}

		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0023BF84 File Offset: 0x0023A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData(NewbieCarnivalData other) : this()
		{
			this.roleId_ = other.roleId_;
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this.jumpTaskIds_ = other.jumpTaskIds_.Clone();
			this.jumpTaskCondInfos_ = other.jumpTaskCondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x0023BFF2 File Offset: 0x0023A1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData Clone()
		{
			return new NewbieCarnivalData(this);
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x0023BFFA File Offset: 0x0023A1FA
		// (set) Token: 0x0600F4F5 RID: 62709 RVA: 0x0023C002 File Offset: 0x0023A202
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

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600F4F6 RID: 62710 RVA: 0x0023C00B File Offset: 0x0023A20B
		// (set) Token: 0x0600F4F7 RID: 62711 RVA: 0x0023C013 File Offset: 0x0023A213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskData
		{
			get
			{
				return this.activityTaskData_;
			}
			set
			{
				this.activityTaskData_ = value;
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600F4F8 RID: 62712 RVA: 0x0023C01C File Offset: 0x0023A21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JumpTaskIds
		{
			get
			{
				return this.jumpTaskIds_;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600F4F9 RID: 62713 RVA: 0x0023C024 File Offset: 0x0023A224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JumpTaskCondInfo> JumpTaskCondInfos
		{
			get
			{
				return this.jumpTaskCondInfos_;
			}
		}

		// Token: 0x0600F4FA RID: 62714 RVA: 0x0023C02C File Offset: 0x0023A22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalData);
		}

		// Token: 0x0600F4FB RID: 62715 RVA: 0x0023C03C File Offset: 0x0023A23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalData other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.ActivityTaskData, other.ActivityTaskData) && this.jumpTaskIds_.Equals(other.jumpTaskIds_) && this.jumpTaskCondInfos_.Equals(other.jumpTaskCondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x0023C0B4 File Offset: 0x0023A2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.activityTaskData_ != null)
			{
				num ^= this.ActivityTaskData.GetHashCode();
			}
			num ^= this.jumpTaskIds_.GetHashCode();
			num ^= this.jumpTaskCondInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x0023C125 File Offset: 0x0023A325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4FE RID: 62718 RVA: 0x0023C132 File Offset: 0x0023A332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4FF RID: 62719 RVA: 0x0023C13C File Offset: 0x0023A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityTaskData);
			}
			this.jumpTaskIds_.WriteTo(ref output, NewbieCarnivalData._repeated_jumpTaskIds_codec);
			this.jumpTaskCondInfos_.WriteTo(ref output, NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x0023C1B8 File Offset: 0x0023A3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.activityTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskData);
			}
			num += this.jumpTaskIds_.CalculateSize(NewbieCarnivalData._repeated_jumpTaskIds_codec);
			num += this.jumpTaskCondInfos_.CalculateSize(NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F501 RID: 62721 RVA: 0x0023C234 File Offset: 0x0023A434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.activityTaskData_ != null)
			{
				if (this.activityTaskData_ == null)
				{
					this.ActivityTaskData = new ActivityTaskData();
				}
				this.ActivityTaskData.MergeFrom(other.ActivityTaskData);
			}
			this.jumpTaskIds_.Add(other.jumpTaskIds_);
			this.jumpTaskCondInfos_.Add(other.jumpTaskCondInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F502 RID: 62722 RVA: 0x0023C2BE File Offset: 0x0023A4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F503 RID: 62723 RVA: 0x0023C2C8 File Offset: 0x0023A4C8
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.activityTaskData_ == null)
						{
							this.ActivityTaskData = new ActivityTaskData();
						}
						input.ReadMessage(this.ActivityTaskData);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.jumpTaskIds_.AddEntriesFrom(ref input, NewbieCarnivalData._repeated_jumpTaskIds_codec);
						continue;
					}
					if (num == 34U)
					{
						this.jumpTaskCondInfos_.AddEntriesFrom(ref input, NewbieCarnivalData._repeated_jumpTaskCondInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400628F RID: 25231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006290 RID: 25232
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04006291 RID: 25233
		private int roleId_;

		// Token: 0x04006292 RID: 25234
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x04006293 RID: 25235
		private ActivityTaskData activityTaskData_;

		// Token: 0x04006294 RID: 25236
		public const int JumpTaskIdsFieldNumber = 3;

		// Token: 0x04006295 RID: 25237
		private static readonly FieldCodec<int> _repeated_jumpTaskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006296 RID: 25238
		private readonly RepeatedField<int> jumpTaskIds_ = new RepeatedField<int>();

		// Token: 0x04006297 RID: 25239
		public const int JumpTaskCondInfosFieldNumber = 4;

		// Token: 0x04006298 RID: 25240
		private static readonly FieldCodec<JumpTaskCondInfo> _repeated_jumpTaskCondInfos_codec = FieldCodec.ForMessage<JumpTaskCondInfo>(34U, JumpTaskCondInfo.Parser);

		// Token: 0x04006299 RID: 25241
		private readonly RepeatedField<JumpTaskCondInfo> jumpTaskCondInfos_ = new RepeatedField<JumpTaskCondInfo>();
	}
}
