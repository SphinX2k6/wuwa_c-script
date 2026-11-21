using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CF RID: 4303
	[NetMessage(EMessageId.RoleTowerPhantomAddAttrsRequest)]
	public sealed class RoleTowerPhantomAddAttrsRequest : IMessage<RoleTowerPhantomAddAttrsRequest>, IMessage, IEquatable<RoleTowerPhantomAddAttrsRequest>, IDeepCloneable<RoleTowerPhantomAddAttrsRequest>, IBufferMessage
	{
		// Token: 0x06017002 RID: 94210 RVA: 0x00358568 File Offset: 0x00356768
		[NullableContext(1)]
		public static RoleTowerPhantomAddAttrsRequest Create()
		{
			return new RoleTowerPhantomAddAttrsRequest();
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x06017003 RID: 94211 RVA: 0x0035856F File Offset: 0x0035676F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x06017004 RID: 94212 RVA: 0x00358572 File Offset: 0x00356772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomAddAttrsRequest.Descriptor;
			}
		}

		// Token: 0x06017005 RID: 94213 RVA: 0x00358579 File Offset: 0x00356779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsRequest()
		{
		}

		// Token: 0x06017006 RID: 94214 RVA: 0x0035858C File Offset: 0x0035678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsRequest(RoleTowerPhantomAddAttrsRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017007 RID: 94215 RVA: 0x003585C2 File Offset: 0x003567C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsRequest Clone()
		{
			return new RoleTowerPhantomAddAttrsRequest(this);
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x06017008 RID: 94216 RVA: 0x003585CA File Offset: 0x003567CA
		// (set) Token: 0x06017009 RID: 94217 RVA: 0x003585D2 File Offset: 0x003567D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x0601700A RID: 94218 RVA: 0x003585DB File Offset: 0x003567DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0601700B RID: 94219 RVA: 0x003585E3 File Offset: 0x003567E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomAddAttrsRequest);
		}

		// Token: 0x0601700C RID: 94220 RVA: 0x003585F4 File Offset: 0x003567F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomAddAttrsRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x00358644 File Offset: 0x00356844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601700E RID: 94222 RVA: 0x00358691 File Offset: 0x00356891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601700F RID: 94223 RVA: 0x0035869E File Offset: 0x0035689E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017010 RID: 94224 RVA: 0x003586A8 File Offset: 0x003568A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, RoleTowerPhantomAddAttrsRequest._repeated_roleIds_codec);
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017011 RID: 94225 RVA: 0x003586F8 File Offset: 0x003568F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			num += this.roleIds_.CalculateSize(RoleTowerPhantomAddAttrsRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017012 RID: 94226 RVA: 0x0035874C File Offset: 0x0035694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomAddAttrsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017013 RID: 94227 RVA: 0x00358799 File Offset: 0x00356999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017014 RID: 94228 RVA: 0x003587A4 File Offset: 0x003569A4
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
				if (num != 24U && num != 26U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeId = input.ReadInt32();
					}
				}
				else
				{
					this.roleIds_.AddEntriesFrom(ref input, RoleTowerPhantomAddAttrsRequest._repeated_roleIds_codec);
				}
			}
		}

		// Token: 0x040089A9 RID: 35241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089AA RID: 35242
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x040089AB RID: 35243
		private int challengeId_;

		// Token: 0x040089AC RID: 35244
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x040089AD RID: 35245
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040089AE RID: 35246
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
