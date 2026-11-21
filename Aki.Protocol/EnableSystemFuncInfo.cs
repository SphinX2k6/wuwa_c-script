using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041F RID: 1055
	public sealed class EnableSystemFuncInfo : IMessage<EnableSystemFuncInfo>, IMessage, IEquatable<EnableSystemFuncInfo>, IDeepCloneable<EnableSystemFuncInfo>, IBufferMessage
	{
		// Token: 0x060065C3 RID: 26051 RVA: 0x000F51F4 File Offset: 0x000F33F4
		[NullableContext(1)]
		public static EnableSystemFuncInfo Create()
		{
			return new EnableSystemFuncInfo();
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060065C4 RID: 26052 RVA: 0x000F51FB File Offset: 0x000F33FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableSystemFuncInfo> Parser
		{
			get
			{
				return EnableSystemFuncInfo._parser;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x000F5202 File Offset: 0x000F3402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x060065C6 RID: 26054 RVA: 0x000F5205 File Offset: 0x000F3405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableSystemFuncInfo.Descriptor;
			}
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x000F520C File Offset: 0x000F340C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo()
		{
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x000F5214 File Offset: 0x000F3414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo(EnableSystemFuncInfo other) : this()
		{
			this.funcId_ = other.funcId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x000F5245 File Offset: 0x000F3445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo Clone()
		{
			return new EnableSystemFuncInfo(this);
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x000F524D File Offset: 0x000F344D
		// (set) Token: 0x060065CB RID: 26059 RVA: 0x000F5255 File Offset: 0x000F3455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncId
		{
			get
			{
				return this.funcId_;
			}
			set
			{
				this.funcId_ = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x060065CC RID: 26060 RVA: 0x000F525E File Offset: 0x000F345E
		// (set) Token: 0x060065CD RID: 26061 RVA: 0x000F5266 File Offset: 0x000F3466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x000F526F File Offset: 0x000F346F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableSystemFuncInfo);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x000F527D File Offset: 0x000F347D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableSystemFuncInfo other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x000F52BC File Offset: 0x000F34BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x000F5314 File Offset: 0x000F3514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x000F5321 File Offset: 0x000F3521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x000F532C File Offset: 0x000F352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FuncId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x000F5384 File Offset: 0x000F3584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x000F53D0 File Offset: 0x000F35D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableSystemFuncInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x000F5420 File Offset: 0x000F3620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x000F542C File Offset: 0x000F362C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400394C RID: 14668
		private static readonly MessageParser<EnableSystemFuncInfo> _parser = new MessageParser<EnableSystemFuncInfo>(() => new EnableSystemFuncInfo());

		// Token: 0x0400394D RID: 14669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400394E RID: 14670
		public const int FuncIdFieldNumber = 1;

		// Token: 0x0400394F RID: 14671
		private int funcId_;

		// Token: 0x04003950 RID: 14672
		public const int IsOpenFieldNumber = 2;

		// Token: 0x04003951 RID: 14673
		private bool isOpen_;
	}
}
