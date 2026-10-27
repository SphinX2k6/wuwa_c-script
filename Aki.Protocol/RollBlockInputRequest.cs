using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DD RID: 4317
	[NetMessage(EMessageId.RollBlockInputRequest)]
	public sealed class RollBlockInputRequest : IMessage<RollBlockInputRequest>, IMessage, IEquatable<RollBlockInputRequest>, IDeepCloneable<RollBlockInputRequest>, IBufferMessage
	{
		// Token: 0x06017081 RID: 94337 RVA: 0x00357D71 File Offset: 0x00355F71
		[NullableContext(1)]
		public static RollBlockInputRequest Create()
		{
			return new RollBlockInputRequest();
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x06017082 RID: 94338 RVA: 0x00357D78 File Offset: 0x00355F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x06017083 RID: 94339 RVA: 0x00357D7B File Offset: 0x00355F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockInputRequest.Descriptor;
			}
		}

		// Token: 0x06017084 RID: 94340 RVA: 0x00357D82 File Offset: 0x00355F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest()
		{
		}

		// Token: 0x06017085 RID: 94341 RVA: 0x00357D8C File Offset: 0x00355F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest(RollBlockInputRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.input_ = ((other.input_ != null) ? other.input_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017086 RID: 94342 RVA: 0x00357DD8 File Offset: 0x00355FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest Clone()
		{
			return new RollBlockInputRequest(this);
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x06017087 RID: 94343 RVA: 0x00357DE0 File Offset: 0x00355FE0
		// (set) Token: 0x06017088 RID: 94344 RVA: 0x00357DE8 File Offset: 0x00355FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x06017089 RID: 94345 RVA: 0x00357DF1 File Offset: 0x00355FF1
		// (set) Token: 0x0601708A RID: 94346 RVA: 0x00357DF9 File Offset: 0x00355FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput Input
		{
			get
			{
				return this.input_;
			}
			set
			{
				this.input_ = value;
			}
		}

		// Token: 0x0601708B RID: 94347 RVA: 0x00357E02 File Offset: 0x00356002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockInputRequest);
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x00357E10 File Offset: 0x00356010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockInputRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.Input, other.Input) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00357E60 File Offset: 0x00356060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.input_ != null)
			{
				num ^= this.Input.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601708E RID: 94350 RVA: 0x00357EB5 File Offset: 0x003560B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601708F RID: 94351 RVA: 0x00357EC2 File Offset: 0x003560C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017090 RID: 94352 RVA: 0x00357ECC File Offset: 0x003560CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.input_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Input);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017091 RID: 94353 RVA: 0x00357F28 File Offset: 0x00356128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.input_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Input);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017092 RID: 94354 RVA: 0x00357F80 File Offset: 0x00356180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockInputRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.input_ != null)
			{
				if (this.input_ == null)
				{
					this.Input = new RbInput();
				}
				this.Input.MergeFrom(other.Input);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017093 RID: 94355 RVA: 0x00357FE8 File Offset: 0x003561E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017094 RID: 94356 RVA: 0x00357FF4 File Offset: 0x003561F4
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
				if (num != 32U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.input_ == null)
						{
							this.Input = new RbInput();
						}
						input.ReadMessage(this.Input);
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400891F RID: 35103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008920 RID: 35104
		public const int IncIdFieldNumber = 4;

		// Token: 0x04008921 RID: 35105
		private int incId_;

		// Token: 0x04008922 RID: 35106
		public const int InputFieldNumber = 13;

		// Token: 0x04008923 RID: 35107
		private RbInput input_;
	}
}
