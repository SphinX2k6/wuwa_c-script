using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FC RID: 508
	[NetMessage(EMessageId.BuffEffectExecuteRequest)]
	public sealed class BuffEffectExecuteRequest : IMessage<BuffEffectExecuteRequest>, IMessage, IEquatable<BuffEffectExecuteRequest>, IDeepCloneable<BuffEffectExecuteRequest>, IBufferMessage
	{
		// Token: 0x06003868 RID: 14440 RVA: 0x0008CF98 File Offset: 0x0008B198
		[NullableContext(1)]
		public static BuffEffectExecuteRequest Create()
		{
			return new BuffEffectExecuteRequest();
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0008CF9F File Offset: 0x0008B19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x0008CFA2 File Offset: 0x0008B1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecuteRequest.Descriptor;
			}
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x0008CFA9 File Offset: 0x0008B1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest()
		{
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest(BuffEffectExecuteRequest other) : this()
		{
			this.index_ = other.index_;
			this.context_ = ((other.context_ != null) ? other.context_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x0008D000 File Offset: 0x0008B200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest Clone()
		{
			return new BuffEffectExecuteRequest(this);
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x0008D008 File Offset: 0x0008B208
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x0008D010 File Offset: 0x0008B210
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x0008D019 File Offset: 0x0008B219
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x0008D021 File Offset: 0x0008B221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext Context
		{
			get
			{
				return this.context_;
			}
			set
			{
				this.context_ = value;
			}
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x0008D02A File Offset: 0x0008B22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecuteRequest);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0008D038 File Offset: 0x0008B238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecuteRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.Context, other.Context) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x0008D088 File Offset: 0x0008B288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.context_ != null)
			{
				num ^= this.Context.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0008D0DD File Offset: 0x0008B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x0008D0EA File Offset: 0x0008B2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x0008D0F4 File Offset: 0x0008B2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.context_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Context);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x0008D150 File Offset: 0x0008B350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.context_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Context);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x0008D1A8 File Offset: 0x0008B3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecuteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.context_ != null)
			{
				if (this.context_ == null)
				{
					this.Context = new FightBuffEffectContext();
				}
				this.Context.MergeFrom(other.Context);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0008D210 File Offset: 0x0008B410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0008D21C File Offset: 0x0008B41C
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
				if (num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.context_ == null)
					{
						this.Context = new FightBuffEffectContext();
					}
					input.ReadMessage(this.Context);
				}
			}
		}

		// Token: 0x04002B35 RID: 11061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B36 RID: 11062
		public const int IndexFieldNumber = 14;

		// Token: 0x04002B37 RID: 11063
		private int index_;

		// Token: 0x04002B38 RID: 11064
		public const int ContextFieldNumber = 10;

		// Token: 0x04002B39 RID: 11065
		private FightBuffEffectContext context_;
	}
}
