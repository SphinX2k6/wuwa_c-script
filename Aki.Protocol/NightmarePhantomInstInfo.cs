using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B47 RID: 2887
	public sealed class NightmarePhantomInstInfo : IMessage<NightmarePhantomInstInfo>, IMessage, IEquatable<NightmarePhantomInstInfo>, IDeepCloneable<NightmarePhantomInstInfo>, IBufferMessage
	{
		// Token: 0x0600FA9C RID: 64156 RVA: 0x0024896F File Offset: 0x00246B6F
		[NullableContext(1)]
		public static NightmarePhantomInstInfo Create()
		{
			return new NightmarePhantomInstInfo();
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600FA9D RID: 64157 RVA: 0x00248976 File Offset: 0x00246B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NightmarePhantomInstInfo> Parser
		{
			get
			{
				return NightmarePhantomInstInfo._parser;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600FA9E RID: 64158 RVA: 0x0024897D File Offset: 0x00246B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600FA9F RID: 64159 RVA: 0x00248980 File Offset: 0x00246B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NightmarePhantomInstInfo.Descriptor;
			}
		}

		// Token: 0x0600FAA0 RID: 64160 RVA: 0x00248987 File Offset: 0x00246B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo()
		{
		}

		// Token: 0x0600FAA1 RID: 64161 RVA: 0x0024898F File Offset: 0x00246B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo(NightmarePhantomInstInfo other) : this()
		{
			this.insId_ = other.insId_;
			this.killNum_ = other.killNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAA2 RID: 64162 RVA: 0x002489C0 File Offset: 0x00246BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo Clone()
		{
			return new NightmarePhantomInstInfo(this);
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600FAA3 RID: 64163 RVA: 0x002489C8 File Offset: 0x00246BC8
		// (set) Token: 0x0600FAA4 RID: 64164 RVA: 0x002489D0 File Offset: 0x00246BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InsId
		{
			get
			{
				return this.insId_;
			}
			set
			{
				this.insId_ = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600FAA5 RID: 64165 RVA: 0x002489D9 File Offset: 0x00246BD9
		// (set) Token: 0x0600FAA6 RID: 64166 RVA: 0x002489E1 File Offset: 0x00246BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KillNum
		{
			get
			{
				return this.killNum_;
			}
			set
			{
				this.killNum_ = value;
			}
		}

		// Token: 0x0600FAA7 RID: 64167 RVA: 0x002489EA File Offset: 0x00246BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NightmarePhantomInstInfo);
		}

		// Token: 0x0600FAA8 RID: 64168 RVA: 0x002489F8 File Offset: 0x00246BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NightmarePhantomInstInfo other)
		{
			return other != null && (other == this || (this.InsId == other.InsId && this.KillNum == other.KillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAA9 RID: 64169 RVA: 0x00248A38 File Offset: 0x00246C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InsId != 0)
			{
				num ^= this.InsId.GetHashCode();
			}
			if (this.KillNum != 0L)
			{
				num ^= this.KillNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FAAA RID: 64170 RVA: 0x00248A90 File Offset: 0x00246C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAAB RID: 64171 RVA: 0x00248A9D File Offset: 0x00246C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAAC RID: 64172 RVA: 0x00248AA8 File Offset: 0x00246CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InsId);
			}
			if (this.KillNum != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FAAD RID: 64173 RVA: 0x00248B00 File Offset: 0x00246D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InsId);
			}
			if (this.KillNum != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FAAE RID: 64174 RVA: 0x00248B58 File Offset: 0x00246D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NightmarePhantomInstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InsId != 0)
			{
				this.InsId = other.InsId;
			}
			if (other.KillNum != 0L)
			{
				this.KillNum = other.KillNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FAAF RID: 64175 RVA: 0x00248BA8 File Offset: 0x00246DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAB0 RID: 64176 RVA: 0x00248BB4 File Offset: 0x00246DB4
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
						this.KillNum = input.ReadInt64();
					}
				}
				else
				{
					this.InsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400649E RID: 25758
		private static readonly MessageParser<NightmarePhantomInstInfo> _parser = new MessageParser<NightmarePhantomInstInfo>(() => new NightmarePhantomInstInfo());

		// Token: 0x0400649F RID: 25759
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064A0 RID: 25760
		public const int InsIdFieldNumber = 1;

		// Token: 0x040064A1 RID: 25761
		private int insId_;

		// Token: 0x040064A2 RID: 25762
		public const int KillNumFieldNumber = 2;

		// Token: 0x040064A3 RID: 25763
		private long killNum_;
	}
}
