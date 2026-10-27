using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000457 RID: 1111
	[NetMessage(EMessageId.EnterLevelPlayNotify)]
	public sealed class EnterLevelPlayNotify : IMessage<EnterLevelPlayNotify>, IMessage, IEquatable<EnterLevelPlayNotify>, IDeepCloneable<EnterLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x06006A48 RID: 27208 RVA: 0x00100BA1 File Offset: 0x000FEDA1
		[NullableContext(1)]
		public static EnterLevelPlayNotify Create()
		{
			return new EnterLevelPlayNotify();
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x00100BA8 File Offset: 0x000FEDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x00100BAB File Offset: 0x000FEDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00100BB2 File Offset: 0x000FEDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify()
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00100BBA File Offset: 0x000FEDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify(EnterLevelPlayNotify other) : this()
		{
			this.id_ = other.id_;
			this.canGetReward_ = other.canGetReward_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00100BF7 File Offset: 0x000FEDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify Clone()
		{
			return new EnterLevelPlayNotify(this);
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x00100BFF File Offset: 0x000FEDFF
		// (set) Token: 0x06006A4F RID: 27215 RVA: 0x00100C07 File Offset: 0x000FEE07
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x00100C10 File Offset: 0x000FEE10
		// (set) Token: 0x06006A51 RID: 27217 RVA: 0x00100C18 File Offset: 0x000FEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGetReward
		{
			get
			{
				return this.canGetReward_;
			}
			set
			{
				this.canGetReward_ = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00100C21 File Offset: 0x000FEE21
		// (set) Token: 0x06006A53 RID: 27219 RVA: 0x00100C29 File Offset: 0x000FEE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
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

		// Token: 0x06006A54 RID: 27220 RVA: 0x00100C32 File Offset: 0x000FEE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterLevelPlayNotify);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x00100C40 File Offset: 0x000FEE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterLevelPlayNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CanGetReward == other.CanGetReward && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x00100C9C File Offset: 0x000FEE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CanGetReward)
			{
				num ^= this.CanGetReward.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x00100D0D File Offset: 0x000FEF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x00100D1A File Offset: 0x000FEF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00100D24 File Offset: 0x000FEF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.State);
			}
			if (this.CanGetReward)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.CanGetReward);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00100D98 File Offset: 0x000FEF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CanGetReward)
			{
				num += 2;
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00100DFC File Offset: 0x000FEFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CanGetReward)
			{
				this.CanGetReward = other.CanGetReward;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00100E60 File Offset: 0x000FF060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x00100E6C File Offset: 0x000FF06C
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
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.CanGetReward = input.ReadBool();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003A47 RID: 14919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A48 RID: 14920
		public const int IdFieldNumber = 12;

		// Token: 0x04003A49 RID: 14921
		private int id_;

		// Token: 0x04003A4A RID: 14922
		public const int CanGetRewardFieldNumber = 8;

		// Token: 0x04003A4B RID: 14923
		private bool canGetReward_;

		// Token: 0x04003A4C RID: 14924
		public const int StateFieldNumber = 1;

		// Token: 0x04003A4D RID: 14925
		private int state_;
	}
}
