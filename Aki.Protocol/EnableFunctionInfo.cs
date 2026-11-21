using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041D RID: 1053
	public sealed class EnableFunctionInfo : IMessage<EnableFunctionInfo>, IMessage, IEquatable<EnableFunctionInfo>, IDeepCloneable<EnableFunctionInfo>, IBufferMessage
	{
		// Token: 0x06006595 RID: 26005 RVA: 0x000F4B58 File Offset: 0x000F2D58
		[NullableContext(1)]
		public static EnableFunctionInfo Create()
		{
			return new EnableFunctionInfo();
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x000F4B5F File Offset: 0x000F2D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableFunctionInfo> Parser
		{
			get
			{
				return EnableFunctionInfo._parser;
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x000F4B66 File Offset: 0x000F2D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x000F4B69 File Offset: 0x000F2D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableFunctionInfo.Descriptor;
			}
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x000F4B70 File Offset: 0x000F2D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo()
		{
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x000F4B78 File Offset: 0x000F2D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo(EnableFunctionInfo other) : this()
		{
			this.type_ = other.type_;
			this.isEnable_ = other.isEnable_;
			if (other.ParamCase == EnableFunctionInfo.ParamOneofCase.FBParamList)
			{
				this.FBParamList = other.FBParamList.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x000F4BCE File Offset: 0x000F2DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo Clone()
		{
			return new EnableFunctionInfo(this);
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x000F4BD6 File Offset: 0x000F2DD6
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x000F4BDE File Offset: 0x000F2DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x000F4BE7 File Offset: 0x000F2DE7
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x000F4BEF File Offset: 0x000F2DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x000F4BF8 File Offset: 0x000F2DF8
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x000F4C10 File Offset: 0x000F2E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam FBParamList
		{
			get
			{
				if (this.paramCase_ != EnableFunctionInfo.ParamOneofCase.FBParamList)
				{
					return null;
				}
				return (EnableFBParam)this.param_;
			}
			set
			{
				this.param_ = value;
				this.paramCase_ = ((value == null) ? EnableFunctionInfo.ParamOneofCase.None : EnableFunctionInfo.ParamOneofCase.FBParamList);
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x000F4C26 File Offset: 0x000F2E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo.ParamOneofCase ParamCase
		{
			get
			{
				return this.paramCase_;
			}
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x000F4C2E File Offset: 0x000F2E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParam()
		{
			this.paramCase_ = EnableFunctionInfo.ParamOneofCase.None;
			this.param_ = null;
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x000F4C3E File Offset: 0x000F2E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableFunctionInfo);
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x000F4C4C File Offset: 0x000F2E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableFunctionInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.IsEnable == other.IsEnable && object.Equals(this.FBParamList, other.FBParamList) && this.ParamCase == other.ParamCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x000F4CBC File Offset: 0x000F2EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != EnableFunctionType.Invalid)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this.paramCase_ == EnableFunctionInfo.ParamOneofCase.FBParamList)
			{
				num ^= this.FBParamList.GetHashCode();
			}
			num ^= (int)this.paramCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x000F4D3A File Offset: 0x000F2F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x000F4D47 File Offset: 0x000F2F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x000F4D50 File Offset: 0x000F2F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != EnableFunctionType.Invalid)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.IsEnable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnable);
			}
			if (this.paramCase_ == EnableFunctionInfo.ParamOneofCase.FBParamList)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FBParamList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x000F4DC8 File Offset: 0x000F2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != EnableFunctionType.Invalid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this.paramCase_ == EnableFunctionInfo.ParamOneofCase.FBParamList)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FBParamList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x000F4E2C File Offset: 0x000F302C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableFunctionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != EnableFunctionType.Invalid)
			{
				this.Type = other.Type;
			}
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			if (other.ParamCase == EnableFunctionInfo.ParamOneofCase.FBParamList)
			{
				if (this.FBParamList == null)
				{
					this.FBParamList = new EnableFBParam();
				}
				this.FBParamList.MergeFrom(other.FBParamList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x000F4EA9 File Offset: 0x000F30A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x000F4EB4 File Offset: 0x000F30B4
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							EnableFBParam enableFBParam = new EnableFBParam();
							if (this.paramCase_ == EnableFunctionInfo.ParamOneofCase.FBParamList)
							{
								enableFBParam.MergeFrom(this.FBParamList);
							}
							input.ReadMessage(enableFBParam);
							this.FBParamList = enableFBParam;
						}
					}
					else
					{
						this.IsEnable = input.ReadBool();
					}
				}
				else
				{
					this.Type = (EnableFunctionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400393D RID: 14653
		private static readonly MessageParser<EnableFunctionInfo> _parser = new MessageParser<EnableFunctionInfo>(() => new EnableFunctionInfo());

		// Token: 0x0400393E RID: 14654
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400393F RID: 14655
		public const int TypeFieldNumber = 1;

		// Token: 0x04003940 RID: 14656
		private EnableFunctionType type_;

		// Token: 0x04003941 RID: 14657
		public const int IsEnableFieldNumber = 2;

		// Token: 0x04003942 RID: 14658
		private bool isEnable_;

		// Token: 0x04003943 RID: 14659
		public const int FBParamListFieldNumber = 3;

		// Token: 0x04003944 RID: 14660
		private object param_;

		// Token: 0x04003945 RID: 14661
		private EnableFunctionInfo.ParamOneofCase paramCase_;

		// Token: 0x020017DC RID: 6108
		public enum ParamOneofCase
		{
			// Token: 0x0400CB10 RID: 51984
			None,
			// Token: 0x0400CB11 RID: 51985
			FBParamList = 3
		}
	}
}
