using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8E RID: 3982
	[NetMessage(EMessageId.RogueLevelPlayNotify)]
	public sealed class RogueLevelPlayNotify : IMessage<RogueLevelPlayNotify>, IMessage, IEquatable<RogueLevelPlayNotify>, IDeepCloneable<RogueLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x060154BA RID: 87226 RVA: 0x00316F68 File Offset: 0x00315168
		[NullableContext(1)]
		public static RogueLevelPlayNotify Create()
		{
			return new RogueLevelPlayNotify();
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x060154BB RID: 87227 RVA: 0x00316F6F File Offset: 0x0031516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x060154BC RID: 87228 RVA: 0x00316F72 File Offset: 0x00315172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x060154BD RID: 87229 RVA: 0x00316F79 File Offset: 0x00315179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayNotify()
		{
		}

		// Token: 0x060154BE RID: 87230 RVA: 0x00316F84 File Offset: 0x00315184
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

		// Token: 0x060154BF RID: 87231 RVA: 0x00316FD8 File Offset: 0x003151D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayNotify Clone()
		{
			return new RogueLevelPlayNotify(this);
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x060154C0 RID: 87232 RVA: 0x00316FE0 File Offset: 0x003151E0
		// (set) Token: 0x060154C1 RID: 87233 RVA: 0x00316FE8 File Offset: 0x003151E8
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

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x060154C2 RID: 87234 RVA: 0x00316FF1 File Offset: 0x003151F1
		// (set) Token: 0x060154C3 RID: 87235 RVA: 0x00316FF9 File Offset: 0x003151F9
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

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x060154C4 RID: 87236 RVA: 0x00317002 File Offset: 0x00315202
		// (set) Token: 0x060154C5 RID: 87237 RVA: 0x0031700A File Offset: 0x0031520A
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

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x060154C6 RID: 87238 RVA: 0x00317013 File Offset: 0x00315213
		// (set) Token: 0x060154C7 RID: 87239 RVA: 0x0031701B File Offset: 0x0031521B
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

		// Token: 0x060154C8 RID: 87240 RVA: 0x00317024 File Offset: 0x00315224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLevelPlayNotify);
		}

		// Token: 0x060154C9 RID: 87241 RVA: 0x00317034 File Offset: 0x00315234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLevelPlayNotify other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && this.UseTime == other.UseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154CA RID: 87242 RVA: 0x003170A0 File Offset: 0x003152A0
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

		// Token: 0x060154CB RID: 87243 RVA: 0x0031712A File Offset: 0x0031532A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154CC RID: 87244 RVA: 0x00317137 File Offset: 0x00315337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154CD RID: 87245 RVA: 0x00317140 File Offset: 0x00315340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNewRecord)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConfigId);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UseTime);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060154CE RID: 87246 RVA: 0x003171D4 File Offset: 0x003153D4
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

		// Token: 0x060154CF RID: 87247 RVA: 0x00317244 File Offset: 0x00315444
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

		// Token: 0x060154D0 RID: 87248 RVA: 0x003172BC File Offset: 0x003154BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154D1 RID: 87249 RVA: 0x003172C8 File Offset: 0x003154C8
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008021 RID: 32801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008022 RID: 32802
		public const int ConfigIdFieldNumber = 7;

		// Token: 0x04008023 RID: 32803
		private int configId_;

		// Token: 0x04008024 RID: 32804
		public const int IsSuccessFieldNumber = 15;

		// Token: 0x04008025 RID: 32805
		private bool isSuccess_;

		// Token: 0x04008026 RID: 32806
		public const int IsNewRecordFieldNumber = 4;

		// Token: 0x04008027 RID: 32807
		private bool isNewRecord_;

		// Token: 0x04008028 RID: 32808
		public const int UseTimeFieldNumber = 9;

		// Token: 0x04008029 RID: 32809
		private int useTime_;
	}
}
