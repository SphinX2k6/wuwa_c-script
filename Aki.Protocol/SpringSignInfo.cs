using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F0 RID: 4848
	public sealed class SpringSignInfo : IMessage<SpringSignInfo>, IMessage, IEquatable<SpringSignInfo>, IDeepCloneable<SpringSignInfo>, IBufferMessage
	{
		// Token: 0x06019DE0 RID: 105952 RVA: 0x003C5FE8 File Offset: 0x003C41E8
		[NullableContext(1)]
		public static SpringSignInfo Create()
		{
			return new SpringSignInfo();
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x06019DE1 RID: 105953 RVA: 0x003C5FEF File Offset: 0x003C41EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x06019DE2 RID: 105954 RVA: 0x003C5FF2 File Offset: 0x003C41F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignInfo.Descriptor;
			}
		}

		// Token: 0x06019DE3 RID: 105955 RVA: 0x003C5FF9 File Offset: 0x003C41F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo()
		{
		}

		// Token: 0x06019DE4 RID: 105956 RVA: 0x003C6018 File Offset: 0x003C4218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo(SpringSignInfo other) : this()
		{
			this.springSignActivityTasks_ = other.springSignActivityTasks_.Clone();
			this.canInvite_ = other.canInvite_;
			this.drawRoles_ = other.drawRoles_.Clone();
			this.skinReward_ = other.skinReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DE5 RID: 105957 RVA: 0x003C6076 File Offset: 0x003C4276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo Clone()
		{
			return new SpringSignInfo(this);
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x06019DE6 RID: 105958 RVA: 0x003C607E File Offset: 0x003C427E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SpringSignActivityTasks
		{
			get
			{
				return this.springSignActivityTasks_;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x06019DE7 RID: 105959 RVA: 0x003C6086 File Offset: 0x003C4286
		// (set) Token: 0x06019DE8 RID: 105960 RVA: 0x003C608E File Offset: 0x003C428E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanInvite
		{
			get
			{
				return this.canInvite_;
			}
			set
			{
				this.canInvite_ = value;
			}
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x06019DE9 RID: 105961 RVA: 0x003C6097 File Offset: 0x003C4297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DrawRoles
		{
			get
			{
				return this.drawRoles_;
			}
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x06019DEA RID: 105962 RVA: 0x003C609F File Offset: 0x003C429F
		// (set) Token: 0x06019DEB RID: 105963 RVA: 0x003C60A7 File Offset: 0x003C42A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SkinReward
		{
			get
			{
				return this.skinReward_;
			}
			set
			{
				this.skinReward_ = value;
			}
		}

		// Token: 0x06019DEC RID: 105964 RVA: 0x003C60B0 File Offset: 0x003C42B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignInfo);
		}

		// Token: 0x06019DED RID: 105965 RVA: 0x003C60C0 File Offset: 0x003C42C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignInfo other)
		{
			return other != null && (other == this || (this.springSignActivityTasks_.Equals(other.springSignActivityTasks_) && this.CanInvite == other.CanInvite && this.drawRoles_.Equals(other.drawRoles_) && this.SkinReward == other.SkinReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DEE RID: 105966 RVA: 0x003C6134 File Offset: 0x003C4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.springSignActivityTasks_.GetHashCode();
			if (this.CanInvite)
			{
				num ^= this.CanInvite.GetHashCode();
			}
			num ^= this.drawRoles_.GetHashCode();
			if (this.SkinReward)
			{
				num ^= this.SkinReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019DEF RID: 105967 RVA: 0x003C61A8 File Offset: 0x003C43A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DF0 RID: 105968 RVA: 0x003C61B5 File Offset: 0x003C43B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DF1 RID: 105969 RVA: 0x003C61C0 File Offset: 0x003C43C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.springSignActivityTasks_.WriteTo(ref output, SpringSignInfo._repeated_springSignActivityTasks_codec);
			if (this.CanInvite)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanInvite);
			}
			this.drawRoles_.WriteTo(ref output, SpringSignInfo._repeated_drawRoles_codec);
			if (this.SkinReward)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.SkinReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DF2 RID: 105970 RVA: 0x003C623C File Offset: 0x003C443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.springSignActivityTasks_.CalculateSize(SpringSignInfo._repeated_springSignActivityTasks_codec);
			if (this.CanInvite)
			{
				num += 2;
			}
			num += this.drawRoles_.CalculateSize(SpringSignInfo._repeated_drawRoles_codec);
			if (this.SkinReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019DF3 RID: 105971 RVA: 0x003C62A0 File Offset: 0x003C44A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.springSignActivityTasks_.Add(other.springSignActivityTasks_);
			if (other.CanInvite)
			{
				this.CanInvite = other.CanInvite;
			}
			this.drawRoles_.Add(other.drawRoles_);
			if (other.SkinReward)
			{
				this.SkinReward = other.SkinReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019DF4 RID: 105972 RVA: 0x003C6312 File Offset: 0x003C4512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DF5 RID: 105973 RVA: 0x003C631C File Offset: 0x003C451C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.springSignActivityTasks_.AddEntriesFrom(ref input, SpringSignInfo._repeated_springSignActivityTasks_codec);
						continue;
					}
					if (num == 16U)
					{
						this.CanInvite = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.drawRoles_.AddEntriesFrom(ref input, SpringSignInfo._repeated_drawRoles_codec);
						continue;
					}
					if (num == 32U)
					{
						this.SkinReward = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009898 RID: 39064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009899 RID: 39065
		public const int SpringSignActivityTasksFieldNumber = 1;

		// Token: 0x0400989A RID: 39066
		private static readonly FieldCodec<ActivityTask> _repeated_springSignActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x0400989B RID: 39067
		private readonly RepeatedField<ActivityTask> springSignActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x0400989C RID: 39068
		public const int CanInviteFieldNumber = 2;

		// Token: 0x0400989D RID: 39069
		private bool canInvite_;

		// Token: 0x0400989E RID: 39070
		public const int DrawRolesFieldNumber = 3;

		// Token: 0x0400989F RID: 39071
		private static readonly FieldCodec<int> _repeated_drawRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040098A0 RID: 39072
		private readonly RepeatedField<int> drawRoles_ = new RepeatedField<int>();

		// Token: 0x040098A1 RID: 39073
		public const int SkinRewardFieldNumber = 4;

		// Token: 0x040098A2 RID: 39074
		private bool skinReward_;
	}
}
