using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001207 RID: 4615
	[NetMessage(EMessageId.SetClientGlobalVarRequest)]
	public sealed class SetClientGlobalVarRequest : IMessage<SetClientGlobalVarRequest>, IMessage, IEquatable<SetClientGlobalVarRequest>, IDeepCloneable<SetClientGlobalVarRequest>, IBufferMessage
	{
		// Token: 0x06018A8B RID: 101003 RVA: 0x00398B45 File Offset: 0x00396D45
		[NullableContext(1)]
		public static SetClientGlobalVarRequest Create()
		{
			return new SetClientGlobalVarRequest();
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x06018A8C RID: 101004 RVA: 0x00398B4C File Offset: 0x00396D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x06018A8D RID: 101005 RVA: 0x00398B4F File Offset: 0x00396D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientGlobalVarRequest.Descriptor;
			}
		}

		// Token: 0x06018A8E RID: 101006 RVA: 0x00398B56 File Offset: 0x00396D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest()
		{
		}

		// Token: 0x06018A8F RID: 101007 RVA: 0x00398B6C File Offset: 0x00396D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest(SetClientGlobalVarRequest other) : this()
		{
			this.varName_ = other.varName_;
			this.varDefinePb_ = ((other.varDefinePb_ != null) ? other.varDefinePb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A90 RID: 101008 RVA: 0x00398BB8 File Offset: 0x00396DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest Clone()
		{
			return new SetClientGlobalVarRequest(this);
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x06018A91 RID: 101009 RVA: 0x00398BC0 File Offset: 0x00396DC0
		// (set) Token: 0x06018A92 RID: 101010 RVA: 0x00398BC8 File Offset: 0x00396DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string VarName
		{
			get
			{
				return this.varName_;
			}
			set
			{
				this.varName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x06018A93 RID: 101011 RVA: 0x00398BDB File Offset: 0x00396DDB
		// (set) Token: 0x06018A94 RID: 101012 RVA: 0x00398BE3 File Offset: 0x00396DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb VarDefinePb
		{
			get
			{
				return this.varDefinePb_;
			}
			set
			{
				this.varDefinePb_ = value;
			}
		}

		// Token: 0x06018A95 RID: 101013 RVA: 0x00398BEC File Offset: 0x00396DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientGlobalVarRequest);
		}

		// Token: 0x06018A96 RID: 101014 RVA: 0x00398BFC File Offset: 0x00396DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientGlobalVarRequest other)
		{
			return other != null && (other == this || (!(this.VarName != other.VarName) && object.Equals(this.VarDefinePb, other.VarDefinePb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A97 RID: 101015 RVA: 0x00398C50 File Offset: 0x00396E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VarName.Length != 0)
			{
				num ^= this.VarName.GetHashCode();
			}
			if (this.varDefinePb_ != null)
			{
				num ^= this.VarDefinePb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A98 RID: 101016 RVA: 0x00398CA7 File Offset: 0x00396EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A99 RID: 101017 RVA: 0x00398CB4 File Offset: 0x00396EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A9A RID: 101018 RVA: 0x00398CC0 File Offset: 0x00396EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.varDefinePb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.VarDefinePb);
			}
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.VarName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A9B RID: 101019 RVA: 0x00398D20 File Offset: 0x00396F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VarName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VarName);
			}
			if (this.varDefinePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VarDefinePb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A9C RID: 101020 RVA: 0x00398D7C File Offset: 0x00396F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientGlobalVarRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VarName.Length != 0)
			{
				this.VarName = other.VarName;
			}
			if (other.varDefinePb_ != null)
			{
				if (this.varDefinePb_ == null)
				{
					this.VarDefinePb = new VarDefinePb();
				}
				this.VarDefinePb.MergeFrom(other.VarDefinePb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A9D RID: 101021 RVA: 0x00398DE9 File Offset: 0x00396FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A9E RID: 101022 RVA: 0x00398DF4 File Offset: 0x00396FF4
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
				if (num != 18U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.VarName = input.ReadString();
					}
				}
				else
				{
					if (this.varDefinePb_ == null)
					{
						this.VarDefinePb = new VarDefinePb();
					}
					input.ReadMessage(this.VarDefinePb);
				}
			}
		}

		// Token: 0x0400928A RID: 37514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400928B RID: 37515
		public const int VarNameFieldNumber = 6;

		// Token: 0x0400928C RID: 37516
		private string varName_ = "";

		// Token: 0x0400928D RID: 37517
		public const int VarDefinePbFieldNumber = 2;

		// Token: 0x0400928E RID: 37518
		private VarDefinePb varDefinePb_;
	}
}
