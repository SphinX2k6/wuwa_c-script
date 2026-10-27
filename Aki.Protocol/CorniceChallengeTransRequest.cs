using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000303 RID: 771
	[NetMessage(EMessageId.CorniceChallengeTransRequest)]
	public sealed class CorniceChallengeTransRequest : IMessage<CorniceChallengeTransRequest>, IMessage, IEquatable<CorniceChallengeTransRequest>, IDeepCloneable<CorniceChallengeTransRequest>, IBufferMessage
	{
		// Token: 0x06004DE1 RID: 19937 RVA: 0x000BD4E3 File Offset: 0x000BB6E3
		[NullableContext(1)]
		public static CorniceChallengeTransRequest Create()
		{
			return new CorniceChallengeTransRequest();
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004DE2 RID: 19938 RVA: 0x000BD4EA File Offset: 0x000BB6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x000BD4ED File Offset: 0x000BB6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeTransRequest.Descriptor;
			}
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x000BD4F4 File Offset: 0x000BB6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest()
		{
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x000BD4FC File Offset: 0x000BB6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest(CorniceChallengeTransRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x000BD521 File Offset: 0x000BB721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransRequest Clone()
		{
			return new CorniceChallengeTransRequest(this);
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x000BD529 File Offset: 0x000BB729
		// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x000BD531 File Offset: 0x000BB731
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

		// Token: 0x06004DE9 RID: 19945 RVA: 0x000BD53A File Offset: 0x000BB73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeTransRequest);
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x000BD548 File Offset: 0x000BB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeTransRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x000BD578 File Offset: 0x000BB778
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

		// Token: 0x06004DEC RID: 19948 RVA: 0x000BD5B7 File Offset: 0x000BB7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x000BD5C4 File Offset: 0x000BB7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x000BD5CD File Offset: 0x000BB7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x000BD600 File Offset: 0x000BB800
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

		// Token: 0x06004DF0 RID: 19952 RVA: 0x000BD63E File Offset: 0x000BB83E
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

		// Token: 0x06004DF1 RID: 19953 RVA: 0x000BD66F File Offset: 0x000BB86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x000BD678 File Offset: 0x000BB878
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400316F RID: 12655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003170 RID: 12656
		public const int LevelPlayIdFieldNumber = 11;

		// Token: 0x04003171 RID: 12657
		private int levelPlayId_;
	}
}
