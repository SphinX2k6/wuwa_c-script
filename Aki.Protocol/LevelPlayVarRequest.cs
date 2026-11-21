using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000900 RID: 2304
	[NetMessage(EMessageId.LevelPlayVarRequest)]
	public sealed class LevelPlayVarRequest : IMessage<LevelPlayVarRequest>, IMessage, IEquatable<LevelPlayVarRequest>, IDeepCloneable<LevelPlayVarRequest>, IBufferMessage
	{
		// Token: 0x0600CBC6 RID: 52166 RVA: 0x001E0F5D File Offset: 0x001DF15D
		[NullableContext(1)]
		public static LevelPlayVarRequest Create()
		{
			return new LevelPlayVarRequest();
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600CBC7 RID: 52167 RVA: 0x001E0F64 File Offset: 0x001DF164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600CBC8 RID: 52168 RVA: 0x001E0F67 File Offset: 0x001DF167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayVarRequest.Descriptor;
			}
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x001E0F6E File Offset: 0x001DF16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest()
		{
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x001E0F76 File Offset: 0x001DF176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest(LevelPlayVarRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x001E0FA7 File Offset: 0x001DF1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest Clone()
		{
			return new LevelPlayVarRequest(this);
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600CBCC RID: 52172 RVA: 0x001E0FAF File Offset: 0x001DF1AF
		// (set) Token: 0x0600CBCD RID: 52173 RVA: 0x001E0FB7 File Offset: 0x001DF1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x001E0FC0 File Offset: 0x001DF1C0
		// (set) Token: 0x0600CBCF RID: 52175 RVA: 0x001E0FC8 File Offset: 0x001DF1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x001E0FD1 File Offset: 0x001DF1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayVarRequest);
		}

		// Token: 0x0600CBD1 RID: 52177 RVA: 0x001E0FDF File Offset: 0x001DF1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayVarRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x001E1020 File Offset: 0x001DF220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x001E1078 File Offset: 0x001DF278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x001E1085 File Offset: 0x001DF285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x001E1090 File Offset: 0x001DF290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x001E10EC File Offset: 0x001DF2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x001E1144 File Offset: 0x001DF344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayVarRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x001E1194 File Offset: 0x001DF394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x001E11A0 File Offset: 0x001DF3A0
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056D5 RID: 22229
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056D6 RID: 22230
		public const int InstIdFieldNumber = 3;

		// Token: 0x040056D7 RID: 22231
		private int instId_;

		// Token: 0x040056D8 RID: 22232
		public const int LevelPlayIdFieldNumber = 12;

		// Token: 0x040056D9 RID: 22233
		private int levelPlayId_;
	}
}
