using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001008 RID: 4104
	public sealed class RogueTowerTrialBossInfo : IMessage<RogueTowerTrialBossInfo>, IMessage, IEquatable<RogueTowerTrialBossInfo>, IDeepCloneable<RogueTowerTrialBossInfo>, IBufferMessage
	{
		// Token: 0x06015F97 RID: 90007 RVA: 0x003327B7 File Offset: 0x003309B7
		[NullableContext(1)]
		public static RogueTowerTrialBossInfo Create()
		{
			return new RogueTowerTrialBossInfo();
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x06015F98 RID: 90008 RVA: 0x003327BE File Offset: 0x003309BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTowerTrialBossInfo> Parser
		{
			get
			{
				return RogueTowerTrialBossInfo._parser;
			}
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x06015F99 RID: 90009 RVA: 0x003327C5 File Offset: 0x003309C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x06015F9A RID: 90010 RVA: 0x003327C8 File Offset: 0x003309C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialBossInfo.Descriptor;
			}
		}

		// Token: 0x06015F9B RID: 90011 RVA: 0x003327CF File Offset: 0x003309CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo()
		{
		}

		// Token: 0x06015F9C RID: 90012 RVA: 0x003327D7 File Offset: 0x003309D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo(RogueTowerTrialBossInfo other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F9D RID: 90013 RVA: 0x00332808 File Offset: 0x00330A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo Clone()
		{
			return new RogueTowerTrialBossInfo(this);
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x06015F9E RID: 90014 RVA: 0x00332810 File Offset: 0x00330A10
		// (set) Token: 0x06015F9F RID: 90015 RVA: 0x00332818 File Offset: 0x00330A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x06015FA0 RID: 90016 RVA: 0x00332821 File Offset: 0x00330A21
		// (set) Token: 0x06015FA1 RID: 90017 RVA: 0x00332829 File Offset: 0x00330A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06015FA2 RID: 90018 RVA: 0x00332832 File Offset: 0x00330A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialBossInfo);
		}

		// Token: 0x06015FA3 RID: 90019 RVA: 0x00332840 File Offset: 0x00330A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialBossInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FA4 RID: 90020 RVA: 0x00332880 File Offset: 0x00330A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015FA5 RID: 90021 RVA: 0x003328DE File Offset: 0x00330ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FA6 RID: 90022 RVA: 0x003328EB File Offset: 0x00330AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FA7 RID: 90023 RVA: 0x003328F4 File Offset: 0x00330AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FA8 RID: 90024 RVA: 0x0033294C File Offset: 0x00330B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015FA9 RID: 90025 RVA: 0x003329A4 File Offset: 0x00330BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialBossInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != RogueTowerTrialBossState.IsLock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FAA RID: 90026 RVA: 0x003329F4 File Offset: 0x00330BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FAB RID: 90027 RVA: 0x00332A00 File Offset: 0x00330C00
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (RogueTowerTrialBossState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400844C RID: 33868
		private static readonly MessageParser<RogueTowerTrialBossInfo> _parser = new MessageParser<RogueTowerTrialBossInfo>(() => new RogueTowerTrialBossInfo());

		// Token: 0x0400844D RID: 33869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400844E RID: 33870
		public const int IdFieldNumber = 1;

		// Token: 0x0400844F RID: 33871
		private int id_;

		// Token: 0x04008450 RID: 33872
		public const int StateFieldNumber = 2;

		// Token: 0x04008451 RID: 33873
		private RogueTowerTrialBossState state_;
	}
}
