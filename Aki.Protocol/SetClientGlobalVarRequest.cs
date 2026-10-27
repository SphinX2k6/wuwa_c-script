using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CD RID: 4557
	[NetMessage(EMessageId.SetClientGlobalVarRequest)]
	public sealed class SetClientGlobalVarRequest : IMessage<SetClientGlobalVarRequest>, IMessage, IEquatable<SetClientGlobalVarRequest>, IDeepCloneable<SetClientGlobalVarRequest>, IBufferMessage
	{
		// Token: 0x060184EA RID: 99562 RVA: 0x00389811 File Offset: 0x00387A11
		[NullableContext(1)]
		public static SetClientGlobalVarRequest Create()
		{
			return new SetClientGlobalVarRequest();
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x060184EB RID: 99563 RVA: 0x00389818 File Offset: 0x00387A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x060184EC RID: 99564 RVA: 0x0038981B File Offset: 0x00387A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientGlobalVarRequest.Descriptor;
			}
		}

		// Token: 0x060184ED RID: 99565 RVA: 0x00389822 File Offset: 0x00387A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest()
		{
		}

		// Token: 0x060184EE RID: 99566 RVA: 0x00389838 File Offset: 0x00387A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest(SetClientGlobalVarRequest other) : this()
		{
			this.varName_ = other.varName_;
			this.varDefinePb_ = ((other.varDefinePb_ != null) ? other.varDefinePb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184EF RID: 99567 RVA: 0x00389884 File Offset: 0x00387A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarRequest Clone()
		{
			return new SetClientGlobalVarRequest(this);
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x060184F0 RID: 99568 RVA: 0x0038988C File Offset: 0x00387A8C
		// (set) Token: 0x060184F1 RID: 99569 RVA: 0x00389894 File Offset: 0x00387A94
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

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x060184F2 RID: 99570 RVA: 0x003898A7 File Offset: 0x00387AA7
		// (set) Token: 0x060184F3 RID: 99571 RVA: 0x003898AF File Offset: 0x00387AAF
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

		// Token: 0x060184F4 RID: 99572 RVA: 0x003898B8 File Offset: 0x00387AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientGlobalVarRequest);
		}

		// Token: 0x060184F5 RID: 99573 RVA: 0x003898C8 File Offset: 0x00387AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientGlobalVarRequest other)
		{
			return other != null && (other == this || (!(this.VarName != other.VarName) && object.Equals(this.VarDefinePb, other.VarDefinePb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184F6 RID: 99574 RVA: 0x0038991C File Offset: 0x00387B1C
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

		// Token: 0x060184F7 RID: 99575 RVA: 0x00389973 File Offset: 0x00387B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184F8 RID: 99576 RVA: 0x00389980 File Offset: 0x00387B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184F9 RID: 99577 RVA: 0x0038998C File Offset: 0x00387B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.VarName);
			}
			if (this.varDefinePb_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.VarDefinePb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184FA RID: 99578 RVA: 0x003899EC File Offset: 0x00387BEC
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

		// Token: 0x060184FB RID: 99579 RVA: 0x00389A48 File Offset: 0x00387C48
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

		// Token: 0x060184FC RID: 99580 RVA: 0x00389AB5 File Offset: 0x00387CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184FD RID: 99581 RVA: 0x00389AC0 File Offset: 0x00387CC0
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
				if (num != 106U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.VarName = input.ReadString();
				}
			}
		}

		// Token: 0x04008FF7 RID: 36855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FF8 RID: 36856
		public const int VarNameFieldNumber = 13;

		// Token: 0x04008FF9 RID: 36857
		private string varName_ = "";

		// Token: 0x04008FFA RID: 36858
		public const int VarDefinePbFieldNumber = 14;

		// Token: 0x04008FFB RID: 36859
		private VarDefinePb varDefinePb_;
	}
}
