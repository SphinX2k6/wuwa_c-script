using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001281 RID: 4737
	public sealed class SpringSignInfo : IMessage<SpringSignInfo>, IMessage, IEquatable<SpringSignInfo>, IDeepCloneable<SpringSignInfo>, IBufferMessage
	{
		// Token: 0x060193AA RID: 103338 RVA: 0x003AB8B7 File Offset: 0x003A9AB7
		[NullableContext(1)]
		public static SpringSignInfo Create()
		{
			return new SpringSignInfo();
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x060193AB RID: 103339 RVA: 0x003AB8BE File Offset: 0x003A9ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x060193AC RID: 103340 RVA: 0x003AB8C1 File Offset: 0x003A9AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignInfo.Descriptor;
			}
		}

		// Token: 0x060193AD RID: 103341 RVA: 0x003AB8C8 File Offset: 0x003A9AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo()
		{
		}

		// Token: 0x060193AE RID: 103342 RVA: 0x003AB8E8 File Offset: 0x003A9AE8
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

		// Token: 0x060193AF RID: 103343 RVA: 0x003AB946 File Offset: 0x003A9B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo Clone()
		{
			return new SpringSignInfo(this);
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x060193B0 RID: 103344 RVA: 0x003AB94E File Offset: 0x003A9B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SpringSignActivityTasks
		{
			get
			{
				return this.springSignActivityTasks_;
			}
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x060193B1 RID: 103345 RVA: 0x003AB956 File Offset: 0x003A9B56
		// (set) Token: 0x060193B2 RID: 103346 RVA: 0x003AB95E File Offset: 0x003A9B5E
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

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x060193B3 RID: 103347 RVA: 0x003AB967 File Offset: 0x003A9B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DrawRoles
		{
			get
			{
				return this.drawRoles_;
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x060193B4 RID: 103348 RVA: 0x003AB96F File Offset: 0x003A9B6F
		// (set) Token: 0x060193B5 RID: 103349 RVA: 0x003AB977 File Offset: 0x003A9B77
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

		// Token: 0x060193B6 RID: 103350 RVA: 0x003AB980 File Offset: 0x003A9B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignInfo);
		}

		// Token: 0x060193B7 RID: 103351 RVA: 0x003AB990 File Offset: 0x003A9B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignInfo other)
		{
			return other != null && (other == this || (this.springSignActivityTasks_.Equals(other.springSignActivityTasks_) && this.CanInvite == other.CanInvite && this.drawRoles_.Equals(other.drawRoles_) && this.SkinReward == other.SkinReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193B8 RID: 103352 RVA: 0x003ABA04 File Offset: 0x003A9C04
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

		// Token: 0x060193B9 RID: 103353 RVA: 0x003ABA78 File Offset: 0x003A9C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193BA RID: 103354 RVA: 0x003ABA85 File Offset: 0x003A9C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193BB RID: 103355 RVA: 0x003ABA90 File Offset: 0x003A9C90
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

		// Token: 0x060193BC RID: 103356 RVA: 0x003ABB0C File Offset: 0x003A9D0C
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

		// Token: 0x060193BD RID: 103357 RVA: 0x003ABB70 File Offset: 0x003A9D70
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

		// Token: 0x060193BE RID: 103358 RVA: 0x003ABBE2 File Offset: 0x003A9DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193BF RID: 103359 RVA: 0x003ABBEC File Offset: 0x003A9DEC
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

		// Token: 0x0400946E RID: 37998
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400946F RID: 37999
		public const int SpringSignActivityTasksFieldNumber = 1;

		// Token: 0x04009470 RID: 38000
		private static readonly FieldCodec<ActivityTask> _repeated_springSignActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04009471 RID: 38001
		private readonly RepeatedField<ActivityTask> springSignActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04009472 RID: 38002
		public const int CanInviteFieldNumber = 2;

		// Token: 0x04009473 RID: 38003
		private bool canInvite_;

		// Token: 0x04009474 RID: 38004
		public const int DrawRolesFieldNumber = 3;

		// Token: 0x04009475 RID: 38005
		private static readonly FieldCodec<int> _repeated_drawRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009476 RID: 38006
		private readonly RepeatedField<int> drawRoles_ = new RepeatedField<int>();

		// Token: 0x04009477 RID: 38007
		public const int SkinRewardFieldNumber = 4;

		// Token: 0x04009478 RID: 38008
		private bool skinReward_;
	}
}
