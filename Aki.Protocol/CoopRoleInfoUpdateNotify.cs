using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000303 RID: 771
	[NetMessage(EMessageId.CoopRoleInfoUpdateNotify)]
	public sealed class CoopRoleInfoUpdateNotify : IMessage<CoopRoleInfoUpdateNotify>, IMessage, IEquatable<CoopRoleInfoUpdateNotify>, IDeepCloneable<CoopRoleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004E20 RID: 20000 RVA: 0x000BE2AC File Offset: 0x000BC4AC
		[NullableContext(1)]
		public static CoopRoleInfoUpdateNotify Create()
		{
			return new CoopRoleInfoUpdateNotify();
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x000BE2B3 File Offset: 0x000BC4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x000BE2B6 File Offset: 0x000BC4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x000BE2BD File Offset: 0x000BC4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify()
		{
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x000BE2C8 File Offset: 0x000BC4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify(CoopRoleInfoUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			CoopRoleInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
				{
					if (dataCase == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId)
					{
						this.PreCompleteId = other.PreCompleteId;
					}
				}
				else
				{
					this.CoopRoleInfo = other.CoopRoleInfo.Clone();
				}
			}
			else
			{
				this.CoopTaskCompleteInfo = other.CoopTaskCompleteInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x000BE340 File Offset: 0x000BC540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify Clone()
		{
			return new CoopRoleInfoUpdateNotify(this);
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x000BE348 File Offset: 0x000BC548
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x000BE350 File Offset: 0x000BC550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x000BE359 File Offset: 0x000BC559
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x000BE371 File Offset: 0x000BC571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo CoopRoleInfo
		{
			get
			{
				if (this.dataCase_ != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
				{
					return null;
				}
				return (CoopRoleInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? CoopRoleInfoUpdateNotify.DataOneofCase.None : CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo);
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x000BE387 File Offset: 0x000BC587
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x000BE39F File Offset: 0x000BC59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo CoopTaskCompleteInfo
		{
			get
			{
				if (this.dataCase_ != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
				{
					return null;
				}
				return (CoopTaskCompleteInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? CoopRoleInfoUpdateNotify.DataOneofCase.None : CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo);
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x000BE3B5 File Offset: 0x000BC5B5
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x000BE3CC File Offset: 0x000BC5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreCompleteId
		{
			get
			{
				if (!this.HasPreCompleteId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x000BE3E2 File Offset: 0x000BC5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPreCompleteId
		{
			get
			{
				return this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId;
			}
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x000BE3EE File Offset: 0x000BC5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPreCompleteId()
		{
			if (this.HasPreCompleteId)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x000BE3FE File Offset: 0x000BC5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x000BE406 File Offset: 0x000BC606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = CoopRoleInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x000BE416 File Offset: 0x000BC616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleInfoUpdateNotify);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x000BE424 File Offset: 0x000BC624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.CoopRoleInfo, other.CoopRoleInfo) && object.Equals(this.CoopTaskCompleteInfo, other.CoopTaskCompleteInfo) && this.PreCompleteId == other.PreCompleteId && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x000BE4A8 File Offset: 0x000BC6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				num ^= this.CoopRoleInfo.GetHashCode();
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				num ^= this.CoopTaskCompleteInfo.GetHashCode();
			}
			if (this.HasPreCompleteId)
			{
				num ^= this.PreCompleteId.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x000BE537 File Offset: 0x000BC737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x000BE544 File Offset: 0x000BC744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x000BE550 File Offset: 0x000BC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CoopTaskCompleteInfo);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CoopRoleInfo);
			}
			if (this.HasPreCompleteId)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PreCompleteId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x000BE5E4 File Offset: 0x000BC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CoopRoleInfo);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CoopTaskCompleteInfo);
			}
			if (this.HasPreCompleteId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreCompleteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x000BE66C File Offset: 0x000BC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			CoopRoleInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
				{
					if (dataCase == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId)
					{
						this.PreCompleteId = other.PreCompleteId;
					}
				}
				else
				{
					if (this.CoopRoleInfo == null)
					{
						this.CoopRoleInfo = new CoopRoleInfo();
					}
					this.CoopRoleInfo.MergeFrom(other.CoopRoleInfo);
				}
			}
			else
			{
				if (this.CoopTaskCompleteInfo == null)
				{
					this.CoopTaskCompleteInfo = new CoopTaskCompleteInfo();
				}
				this.CoopTaskCompleteInfo.MergeFrom(other.CoopTaskCompleteInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x000BE716 File Offset: 0x000BC916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x000BE720 File Offset: 0x000BC920
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
				if (num <= 66U)
				{
					if (num == 26U)
					{
						CoopTaskCompleteInfo coopTaskCompleteInfo = new CoopTaskCompleteInfo();
						if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
						{
							coopTaskCompleteInfo.MergeFrom(this.CoopTaskCompleteInfo);
						}
						input.ReadMessage(coopTaskCompleteInfo);
						this.CoopTaskCompleteInfo = coopTaskCompleteInfo;
						continue;
					}
					if (num == 66U)
					{
						CoopRoleInfo coopRoleInfo = new CoopRoleInfo();
						if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
						{
							coopRoleInfo.MergeFrom(this.CoopRoleInfo);
						}
						input.ReadMessage(coopRoleInfo);
						this.CoopRoleInfo = coopRoleInfo;
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.PreCompleteId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031DA RID: 12762
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031DB RID: 12763
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x040031DC RID: 12764
		private int activityId_;

		// Token: 0x040031DD RID: 12765
		public const int CoopRoleInfoFieldNumber = 8;

		// Token: 0x040031DE RID: 12766
		public const int CoopTaskCompleteInfoFieldNumber = 3;

		// Token: 0x040031DF RID: 12767
		public const int PreCompleteIdFieldNumber = 9;

		// Token: 0x040031E0 RID: 12768
		private object data_;

		// Token: 0x040031E1 RID: 12769
		private CoopRoleInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020017AE RID: 6062
		public enum DataOneofCase
		{
			// Token: 0x0400CACC RID: 51916
			None,
			// Token: 0x0400CACD RID: 51917
			CoopRoleInfo = 8,
			// Token: 0x0400CACE RID: 51918
			CoopTaskCompleteInfo = 3,
			// Token: 0x0400CACF RID: 51919
			PreCompleteId = 9
		}
	}
}
