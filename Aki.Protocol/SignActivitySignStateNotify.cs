using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001256 RID: 4694
	[NetMessage(EMessageId.SignActivitySignStateNotify)]
	public sealed class SignActivitySignStateNotify : IMessage<SignActivitySignStateNotify>, IMessage, IEquatable<SignActivitySignStateNotify>, IDeepCloneable<SignActivitySignStateNotify>, IBufferMessage
	{
		// Token: 0x060190F3 RID: 102643 RVA: 0x003A72A2 File Offset: 0x003A54A2
		[NullableContext(1)]
		public static SignActivitySignStateNotify Create()
		{
			return new SignActivitySignStateNotify();
		}

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x060190F4 RID: 102644 RVA: 0x003A72A9 File Offset: 0x003A54A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x060190F5 RID: 102645 RVA: 0x003A72AC File Offset: 0x003A54AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivitySignStateNotify.Descriptor;
			}
		}

		// Token: 0x060190F6 RID: 102646 RVA: 0x003A72B3 File Offset: 0x003A54B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify()
		{
		}

		// Token: 0x060190F7 RID: 102647 RVA: 0x003A72BB File Offset: 0x003A54BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify(SignActivitySignStateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this.signState_ = other.signState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190F8 RID: 102648 RVA: 0x003A72F8 File Offset: 0x003A54F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify Clone()
		{
			return new SignActivitySignStateNotify(this);
		}

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x060190F9 RID: 102649 RVA: 0x003A7300 File Offset: 0x003A5500
		// (set) Token: 0x060190FA RID: 102650 RVA: 0x003A7308 File Offset: 0x003A5508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x060190FB RID: 102651 RVA: 0x003A7311 File Offset: 0x003A5511
		// (set) Token: 0x060190FC RID: 102652 RVA: 0x003A7319 File Offset: 0x003A5519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x060190FD RID: 102653 RVA: 0x003A7322 File Offset: 0x003A5522
		// (set) Token: 0x060190FE RID: 102654 RVA: 0x003A732A File Offset: 0x003A552A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState SignState
		{
			get
			{
				return this.signState_;
			}
			set
			{
				this.signState_ = value;
			}
		}

		// Token: 0x060190FF RID: 102655 RVA: 0x003A7333 File Offset: 0x003A5533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivitySignStateNotify);
		}

		// Token: 0x06019100 RID: 102656 RVA: 0x003A7344 File Offset: 0x003A5544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivitySignStateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && this.SignState == other.SignState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019101 RID: 102657 RVA: 0x003A73A0 File Offset: 0x003A55A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.SignState != SignState.Lock)
			{
				num ^= this.SignState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019102 RID: 102658 RVA: 0x003A7417 File Offset: 0x003A5617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019103 RID: 102659 RVA: 0x003A7424 File Offset: 0x003A5624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019104 RID: 102660 RVA: 0x003A7430 File Offset: 0x003A5630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.SignState != SignState.Lock)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.SignState);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019105 RID: 102661 RVA: 0x003A74A8 File Offset: 0x003A56A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.SignState != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SignState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019106 RID: 102662 RVA: 0x003A7518 File Offset: 0x003A5718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivitySignStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.SignState != SignState.Lock)
			{
				this.SignState = other.SignState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019107 RID: 102663 RVA: 0x003A757C File Offset: 0x003A577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019108 RID: 102664 RVA: 0x003A7588 File Offset: 0x003A5788
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.SignState = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400947C RID: 38012
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400947D RID: 38013
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x0400947E RID: 38014
		private int activityId_;

		// Token: 0x0400947F RID: 38015
		public const int IndexFieldNumber = 2;

		// Token: 0x04009480 RID: 38016
		private int index_;

		// Token: 0x04009481 RID: 38017
		public const int SignStateFieldNumber = 7;

		// Token: 0x04009482 RID: 38018
		private SignState signState_;
	}
}
