using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7E RID: 3966
	[NetMessage(EMessageId.RogueLevelPlayNotify)]
	public sealed class RogueLevelPlayNotify : IMessage<RogueLevelPlayNotify>, IMessage, IEquatable<RogueLevelPlayNotify>, IDeepCloneable<RogueLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x060153D5 RID: 86997 RVA: 0x003158B4 File Offset: 0x00313AB4
		[NullableContext(1)]
		public static RogueLevelPlayNotify Create()
		{
			return new RogueLevelPlayNotify();
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x060153D6 RID: 86998 RVA: 0x003158BB File Offset: 0x00313ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x060153D7 RID: 86999 RVA: 0x003158BE File Offset: 0x00313ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x060153D8 RID: 87000 RVA: 0x003158C5 File Offset: 0x00313AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayNotify()
		{
		}

		// Token: 0x060153D9 RID: 87001 RVA: 0x003158D0 File Offset: 0x00313AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayNotify(RogueLevelPlayNotify other) : this()
		{
			this.configId_ = other.configId_;
			this.isSuccess_ = other.isSuccess_;
			this.isNewRecord_ = other.isNewRecord_;
			this.useTime_ = other.useTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060153DA RID: 87002 RVA: 0x00315924 File Offset: 0x00313B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayNotify Clone()
		{
			return new RogueLevelPlayNotify(this);
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x060153DB RID: 87003 RVA: 0x0031592C File Offset: 0x00313B2C
		// (set) Token: 0x060153DC RID: 87004 RVA: 0x00315934 File Offset: 0x00313B34
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

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x060153DD RID: 87005 RVA: 0x0031593D File Offset: 0x00313B3D
		// (set) Token: 0x060153DE RID: 87006 RVA: 0x00315945 File Offset: 0x00313B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x060153DF RID: 87007 RVA: 0x0031594E File Offset: 0x00313B4E
		// (set) Token: 0x060153E0 RID: 87008 RVA: 0x00315956 File Offset: 0x00313B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x060153E1 RID: 87009 RVA: 0x0031595F File Offset: 0x00313B5F
		// (set) Token: 0x060153E2 RID: 87010 RVA: 0x00315967 File Offset: 0x00313B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x060153E3 RID: 87011 RVA: 0x00315970 File Offset: 0x00313B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLevelPlayNotify);
		}

		// Token: 0x060153E4 RID: 87012 RVA: 0x00315980 File Offset: 0x00313B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLevelPlayNotify other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && this.UseTime == other.UseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153E5 RID: 87013 RVA: 0x003159EC File Offset: 0x00313BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060153E6 RID: 87014 RVA: 0x00315A76 File Offset: 0x00313C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153E7 RID: 87015 RVA: 0x00315A83 File Offset: 0x00313C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153E8 RID: 87016 RVA: 0x00315A8C File Offset: 0x00313C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSuccess)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSuccess);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.UseTime);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsNewRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060153E9 RID: 87017 RVA: 0x00315B20 File Offset: 0x00313D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060153EA RID: 87018 RVA: 0x00315B90 File Offset: 0x00313D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060153EB RID: 87019 RVA: 0x00315C08 File Offset: 0x00313E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060153EC RID: 87020 RVA: 0x00315C14 File Offset: 0x00313E14
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
				if (num <= 88U)
				{
					if (num == 48U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400804B RID: 32843
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400804C RID: 32844
		public const int ConfigIdFieldNumber = 12;

		// Token: 0x0400804D RID: 32845
		private int configId_;

		// Token: 0x0400804E RID: 32846
		public const int IsSuccessFieldNumber = 6;

		// Token: 0x0400804F RID: 32847
		private bool isSuccess_;

		// Token: 0x04008050 RID: 32848
		public const int IsNewRecordFieldNumber = 13;

		// Token: 0x04008051 RID: 32849
		private bool isNewRecord_;

		// Token: 0x04008052 RID: 32850
		public const int UseTimeFieldNumber = 11;

		// Token: 0x04008053 RID: 32851
		private int useTime_;
	}
}
