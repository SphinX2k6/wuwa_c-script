using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012B RID: 299
	public sealed class AudioStatePb : IMessage<AudioStatePb>, IMessage, IEquatable<AudioStatePb>, IDeepCloneable<AudioStatePb>, IBufferMessage
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00068FF3 File Offset: 0x000671F3
		[NullableContext(1)]
		public static AudioStatePb Create()
		{
			return new AudioStatePb();
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x00068FFA File Offset: 0x000671FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AudioStatePb> Parser
		{
			get
			{
				return AudioStatePb._parser;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00069001 File Offset: 0x00067201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00069004 File Offset: 0x00067204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AudioStatePb.Descriptor;
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0006900B File Offset: 0x0006720B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStatePb()
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0006902C File Offset: 0x0006722C
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

		// Token: 0x060027C7 RID: 10183 RVA: 0x00069080 File Offset: 0x00067280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStatePb Clone()
		{
			return new AudioStatePb(this);
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00069088 File Offset: 0x00067288
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x00069090 File Offset: 0x00067290
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x00069099 File Offset: 0x00067299
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x000690A1 File Offset: 0x000672A1
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000690AA File Offset: 0x000672AA
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x000690B2 File Offset: 0x000672B2
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000690C5 File Offset: 0x000672C5
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x000690CD File Offset: 0x000672CD
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

		// Token: 0x060027D0 RID: 10192 RVA: 0x000690E0 File Offset: 0x000672E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AudioStatePb);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000690F0 File Offset: 0x000672F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AudioStatePb other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.Group != other.Group) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00069164 File Offset: 0x00067364
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

		// Token: 0x060027D3 RID: 10195 RVA: 0x000691F2 File Offset: 0x000673F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000691FF File Offset: 0x000673FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00069208 File Offset: 0x00067408
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

		// Token: 0x060027D6 RID: 10198 RVA: 0x000692A4 File Offset: 0x000674A4
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

		// Token: 0x060027D7 RID: 10199 RVA: 0x00069334 File Offset: 0x00067534
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

		// Token: 0x060027D8 RID: 10200 RVA: 0x000693B6 File Offset: 0x000675B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000693C0 File Offset: 0x000675C0
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

		// Token: 0x04002676 RID: 9846
		private static readonly MessageParser<AudioStatePb> _parser = new MessageParser<AudioStatePb>(() => new AudioStatePb());

		// Token: 0x04002677 RID: 9847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002678 RID: 9848
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002679 RID: 9849
		private int treeOwnerId_;

		// Token: 0x0400267A RID: 9850
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x0400267B RID: 9851
		private long treeIncId_;

		// Token: 0x0400267C RID: 9852
		public const int GroupFieldNumber = 3;

		// Token: 0x0400267D RID: 9853
		private string group_ = "";

		// Token: 0x0400267E RID: 9854
		public const int StateFieldNumber = 4;

		// Token: 0x0400267F RID: 9855
		private string state_ = "";
	}
}
