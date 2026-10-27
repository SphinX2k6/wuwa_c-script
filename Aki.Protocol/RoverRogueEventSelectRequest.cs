using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FB RID: 4347
	[NetMessage(EMessageId.RoverRogueEventSelectRequest)]
	public sealed class RoverRogueEventSelectRequest : IMessage<RoverRogueEventSelectRequest>, IMessage, IEquatable<RoverRogueEventSelectRequest>, IDeepCloneable<RoverRogueEventSelectRequest>, IBufferMessage
	{
		// Token: 0x060172E3 RID: 94947 RVA: 0x0035D378 File Offset: 0x0035B578
		[NullableContext(1)]
		public static RoverRogueEventSelectRequest Create()
		{
			return new RoverRogueEventSelectRequest();
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x060172E4 RID: 94948 RVA: 0x0035D37F File Offset: 0x0035B57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x060172E5 RID: 94949 RVA: 0x0035D382 File Offset: 0x0035B582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventSelectRequest.Descriptor;
			}
		}

		// Token: 0x060172E6 RID: 94950 RVA: 0x0035D389 File Offset: 0x0035B589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest()
		{
		}

		// Token: 0x060172E7 RID: 94951 RVA: 0x0035D391 File Offset: 0x0035B591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest(RoverRogueEventSelectRequest other) : this()
		{
			this.eventIncId_ = other.eventIncId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x0035D3C2 File Offset: 0x0035B5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest Clone()
		{
			return new RoverRogueEventSelectRequest(this);
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x060172E9 RID: 94953 RVA: 0x0035D3CA File Offset: 0x0035B5CA
		// (set) Token: 0x060172EA RID: 94954 RVA: 0x0035D3D2 File Offset: 0x0035B5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventIncId
		{
			get
			{
				return this.eventIncId_;
			}
			set
			{
				this.eventIncId_ = value;
			}
		}

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x060172EB RID: 94955 RVA: 0x0035D3DB File Offset: 0x0035B5DB
		// (set) Token: 0x060172EC RID: 94956 RVA: 0x0035D3E3 File Offset: 0x0035B5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0035D3EC File Offset: 0x0035B5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventSelectRequest);
		}

		// Token: 0x060172EE RID: 94958 RVA: 0x0035D3FA File Offset: 0x0035B5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventSelectRequest other)
		{
			return other != null && (other == this || (this.EventIncId == other.EventIncId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x0035D438 File Offset: 0x0035B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventIncId != 0)
			{
				num ^= this.EventIncId.GetHashCode();
			}
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172F0 RID: 94960 RVA: 0x0035D490 File Offset: 0x0035B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172F1 RID: 94961 RVA: 0x0035D49D File Offset: 0x0035B69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172F2 RID: 94962 RVA: 0x0035D4A8 File Offset: 0x0035B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.EventIncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EventIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172F3 RID: 94963 RVA: 0x0035D504 File Offset: 0x0035B704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventIncId);
			}
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172F4 RID: 94964 RVA: 0x0035D55C File Offset: 0x0035B75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventIncId != 0)
			{
				this.EventIncId = other.EventIncId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172F5 RID: 94965 RVA: 0x0035D5AC File Offset: 0x0035B7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172F6 RID: 94966 RVA: 0x0035D5B8 File Offset: 0x0035B7B8
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventIncId = input.ReadInt32();
					}
				}
				else
				{
					this.ChoiceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040089DA RID: 35290
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089DB RID: 35291
		public const int EventIncIdFieldNumber = 9;

		// Token: 0x040089DC RID: 35292
		private int eventIncId_;

		// Token: 0x040089DD RID: 35293
		public const int ChoiceIdFieldNumber = 7;

		// Token: 0x040089DE RID: 35294
		private int choiceId_;
	}
}
