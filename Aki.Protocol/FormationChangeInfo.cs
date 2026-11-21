using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000616 RID: 1558
	public sealed class FormationChangeInfo : IMessage<FormationChangeInfo>, IMessage, IEquatable<FormationChangeInfo>, IDeepCloneable<FormationChangeInfo>, IBufferMessage
	{
		// Token: 0x06009032 RID: 36914 RVA: 0x0015D8C4 File Offset: 0x0015BAC4
		[NullableContext(1)]
		public static FormationChangeInfo Create()
		{
			return new FormationChangeInfo();
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06009033 RID: 36915 RVA: 0x0015D8CB File Offset: 0x0015BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationChangeInfo> Parser
		{
			get
			{
				return FormationChangeInfo._parser;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x0015D8D2 File Offset: 0x0015BAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06009035 RID: 36917 RVA: 0x0015D8D5 File Offset: 0x0015BAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeInfo.Descriptor;
			}
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x0015D8DC File Offset: 0x0015BADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo()
		{
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x0015D8EF File Offset: 0x0015BAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo(FormationChangeInfo other) : this()
		{
			this.id_ = other.id_;
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0015D925 File Offset: 0x0015BB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo Clone()
		{
			return new FormationChangeInfo(this);
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06009039 RID: 36921 RVA: 0x0015D92D File Offset: 0x0015BB2D
		// (set) Token: 0x0600903A RID: 36922 RVA: 0x0015D935 File Offset: 0x0015BB35
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

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x0600903B RID: 36923 RVA: 0x0015D93E File Offset: 0x0015BB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x0015D946 File Offset: 0x0015BB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeInfo);
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x0015D954 File Offset: 0x0015BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.role_.Equals(other.role_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x0015D9A4 File Offset: 0x0015BBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x0015D9F1 File Offset: 0x0015BBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x0015D9FE File Offset: 0x0015BBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0015DA08 File Offset: 0x0015BC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.role_.WriteTo(ref output, FormationChangeInfo._repeated_role_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0015DA58 File Offset: 0x0015BC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.role_.CalculateSize(FormationChangeInfo._repeated_role_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0015DAAC File Offset: 0x0015BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.role_.Add(other.role_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x0015DAF9 File Offset: 0x0015BCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0015DB04 File Offset: 0x0015BD04
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, FormationChangeInfo._repeated_role_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004645 RID: 17989
		private static readonly MessageParser<FormationChangeInfo> _parser = new MessageParser<FormationChangeInfo>(() => new FormationChangeInfo());

		// Token: 0x04004646 RID: 17990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004647 RID: 17991
		public const int IdFieldNumber = 1;

		// Token: 0x04004648 RID: 17992
		private int id_;

		// Token: 0x04004649 RID: 17993
		public const int RoleFieldNumber = 2;

		// Token: 0x0400464A RID: 17994
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400464B RID: 17995
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();
	}
}
