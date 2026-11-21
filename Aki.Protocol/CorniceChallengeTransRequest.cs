using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030A RID: 778
	[NetMessage(EMessageId.CorniceChallengeTransRequest)]
	public sealed class CorniceChallengeTransRequest : IMessage<CorniceChallengeTransRequest>, IMessage, IEquatable<CorniceChallengeTransRequest>, IDeepCloneable<CorniceChallengeTransRequest>, IBufferMessage
	{
		// Token: 0x06004EBA RID: 20154 RVA: 0x000BF8CF File Offset: 0x000BDACF
		[NullableContext(1)]
		public static CorniceChallengeTransRequest Create()
		{
			return new CorniceChallengeTransRequest();
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x000BF8D6 File Offset: 0x000BDAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x000BF8D9 File Offset: 0x000BDAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeTransRequest.Descriptor;
			}
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x000BF8E0 File Offset: 0x000BDAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest()
		{
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x000BF8E8 File Offset: 0x000BDAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest(CorniceChallengeTransRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x000BF90D File Offset: 0x000BDB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest Clone()
		{
			return new CorniceChallengeTransRequest(this);
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x000BF915 File Offset: 0x000BDB15
		// (set) Token: 0x06004EC1 RID: 20161 RVA: 0x000BF91D File Offset: 0x000BDB1D
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

		// Token: 0x06004EC2 RID: 20162 RVA: 0x000BF926 File Offset: 0x000BDB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeTransRequest);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000BF934 File Offset: 0x000BDB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeTransRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x000BF964 File Offset: 0x000BDB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06004EC5 RID: 20165 RVA: 0x000BF9A3 File Offset: 0x000BDBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x000BF9B0 File Offset: 0x000BDBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x000BF9B9 File Offset: 0x000BDBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x000BF9EC File Offset: 0x000BDBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06004EC9 RID: 20169 RVA: 0x000BFA2A File Offset: 0x000BDC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceChallengeTransRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x000BFA5B File Offset: 0x000BDC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x000BFA64 File Offset: 0x000BDC64
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003206 RID: 12806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003207 RID: 12807
		public const int LevelPlayIdFieldNumber = 13;

		// Token: 0x04003208 RID: 12808
		private int levelPlayId_;
	}
}
