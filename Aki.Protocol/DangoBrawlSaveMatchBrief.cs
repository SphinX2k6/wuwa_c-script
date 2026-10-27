using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000366 RID: 870
	public sealed class DangoBrawlSaveMatchBrief : IMessage<DangoBrawlSaveMatchBrief>, IMessage, IEquatable<DangoBrawlSaveMatchBrief>, IDeepCloneable<DangoBrawlSaveMatchBrief>, IBufferMessage
	{
		// Token: 0x060056BE RID: 22206 RVA: 0x000D40D8 File Offset: 0x000D22D8
		[NullableContext(1)]
		public static DangoBrawlSaveMatchBrief Create()
		{
			return new DangoBrawlSaveMatchBrief();
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060056BF RID: 22207 RVA: 0x000D40DF File Offset: 0x000D22DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x000D40E2 File Offset: 0x000D22E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSaveMatchBrief.Descriptor;
			}
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x000D40E9 File Offset: 0x000D22E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief()
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x000D40F1 File Offset: 0x000D22F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief(DangoBrawlSaveMatchBrief other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roundNum_ = other.roundNum_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x000D412E File Offset: 0x000D232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief Clone()
		{
			return new DangoBrawlSaveMatchBrief(this);
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x000D4136 File Offset: 0x000D2336
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x000D413E File Offset: 0x000D233E
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

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x000D4147 File Offset: 0x000D2347
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x000D414F File Offset: 0x000D234F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x000D4158 File Offset: 0x000D2358
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x000D4160 File Offset: 0x000D2360
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

		// Token: 0x060056CA RID: 22218 RVA: 0x000D4169 File Offset: 0x000D2369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSaveMatchBrief);
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x000D4178 File Offset: 0x000D2378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSaveMatchBrief other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoundNum == other.RoundNum && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x000D41D4 File Offset: 0x000D23D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x000D4245 File Offset: 0x000D2445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x000D4252 File Offset: 0x000D2452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x000D425C File Offset: 0x000D245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoundNum);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x000D42D0 File Offset: 0x000D24D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x000D4340 File Offset: 0x000D2540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSaveMatchBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x000D43A4 File Offset: 0x000D25A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x000D43B0 File Offset: 0x000D25B0
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
						if (num != 24U)
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
						this.RoundNum = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040034A0 RID: 13472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034A1 RID: 13473
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040034A2 RID: 13474
		private int challengeId_;

		// Token: 0x040034A3 RID: 13475
		public const int RoundNumFieldNumber = 2;

		// Token: 0x040034A4 RID: 13476
		private int roundNum_;

		// Token: 0x040034A5 RID: 13477
		public const int RoleIdFieldNumber = 3;

		// Token: 0x040034A6 RID: 13478
		private int roleId_;
	}
}
