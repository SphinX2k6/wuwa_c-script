using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012E RID: 302
	public sealed class AudioStatePb : IMessage<AudioStatePb>, IMessage, IEquatable<AudioStatePb>, IDeepCloneable<AudioStatePb>, IBufferMessage
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x0006A41C File Offset: 0x0006861C
		[NullableContext(1)]
		public static AudioStatePb Create()
		{
			return new AudioStatePb();
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x0006A423 File Offset: 0x00068623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AudioStatePb> Parser
		{
			get
			{
				return AudioStatePb._parser;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x0006A42A File Offset: 0x0006862A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x0006A42D File Offset: 0x0006862D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AudioStatePb.Descriptor;
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0006A434 File Offset: 0x00068634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStatePb()
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0006A454 File Offset: 0x00068654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStatePb(AudioStatePb other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.group_ = other.group_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0006A4A8 File Offset: 0x000686A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStatePb Clone()
		{
			return new AudioStatePb(this);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0006A4B0 File Offset: 0x000686B0
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x0006A4B8 File Offset: 0x000686B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0006A4C1 File Offset: 0x000686C1
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x0006A4C9 File Offset: 0x000686C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0006A4D2 File Offset: 0x000686D2
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0006A4DA File Offset: 0x000686DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x0006A4ED File Offset: 0x000686ED
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0006A4F5 File Offset: 0x000686F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0006A508 File Offset: 0x00068708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AudioStatePb);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0006A518 File Offset: 0x00068718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AudioStatePb other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.Group != other.Group) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0006A58C File Offset: 0x0006878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.Group.Length != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0006A61A File Offset: 0x0006881A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0006A627 File Offset: 0x00068827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0006A630 File Offset: 0x00068830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.Group.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Group);
			}
			if (this.State.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0006A6CC File Offset: 0x000688CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.Group.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Group);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0006A75C File Offset: 0x0006895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AudioStatePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.Group.Length != 0)
			{
				this.Group = other.Group;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0006A7DE File Offset: 0x000689DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0006A7E8 File Offset: 0x000689E8
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
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.Group = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.State = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026EA RID: 9962
		private static readonly MessageParser<AudioStatePb> _parser = new MessageParser<AudioStatePb>(() => new AudioStatePb());

		// Token: 0x040026EB RID: 9963
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026EC RID: 9964
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x040026ED RID: 9965
		private int treeOwnerId_;

		// Token: 0x040026EE RID: 9966
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x040026EF RID: 9967
		private long treeIncId_;

		// Token: 0x040026F0 RID: 9968
		public const int GroupFieldNumber = 3;

		// Token: 0x040026F1 RID: 9969
		private string group_ = "";

		// Token: 0x040026F2 RID: 9970
		public const int StateFieldNumber = 4;

		// Token: 0x040026F3 RID: 9971
		private string state_ = "";
	}
}
