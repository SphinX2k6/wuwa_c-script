using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000434 RID: 1076
	public sealed class EnableFunctionInfo : IMessage<EnableFunctionInfo>, IMessage, IEquatable<EnableFunctionInfo>, IDeepCloneable<EnableFunctionInfo>, IBufferMessage
	{
		// Token: 0x06006725 RID: 26405 RVA: 0x000F7CD4 File Offset: 0x000F5ED4
		[NullableContext(1)]
		public static EnableFunctionInfo Create()
		{
			return new EnableFunctionInfo();
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x000F7CDB File Offset: 0x000F5EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableFunctionInfo> Parser
		{
			get
			{
				return EnableFunctionInfo._parser;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06006727 RID: 26407 RVA: 0x000F7CE2 File Offset: 0x000F5EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x000F7CE5 File Offset: 0x000F5EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableFunctionInfo.Descriptor;
			}
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x000F7CEC File Offset: 0x000F5EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo()
		{
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x000F7CF4 File Offset: 0x000F5EF4
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

		// Token: 0x0600672B RID: 26411 RVA: 0x000F7D4A File Offset: 0x000F5F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo Clone()
		{
			return new EnableFunctionInfo(this);
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x000F7D52 File Offset: 0x000F5F52
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x000F7D5A File Offset: 0x000F5F5A
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

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x000F7D63 File Offset: 0x000F5F63
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x000F7D6B File Offset: 0x000F5F6B
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

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x000F7D74 File Offset: 0x000F5F74
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x000F7D8C File Offset: 0x000F5F8C
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

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x000F7DA2 File Offset: 0x000F5FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFunctionInfo.ParamOneofCase ParamCase
		{
			get
			{
				return this.paramCase_;
			}
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x000F7DAA File Offset: 0x000F5FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParam()
		{
			this.paramCase_ = EnableFunctionInfo.ParamOneofCase.None;
			this.param_ = null;
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x000F7DBA File Offset: 0x000F5FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableFunctionInfo);
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x000F7DC8 File Offset: 0x000F5FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableFunctionInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.IsEnable == other.IsEnable && object.Equals(this.FBParamList, other.FBParamList) && this.ParamCase == other.ParamCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x000F7E38 File Offset: 0x000F6038
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

		// Token: 0x06006737 RID: 26423 RVA: 0x000F7EB6 File Offset: 0x000F60B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x000F7EC3 File Offset: 0x000F60C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x000F7ECC File Offset: 0x000F60CC
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

		// Token: 0x0600673A RID: 26426 RVA: 0x000F7F44 File Offset: 0x000F6144
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

		// Token: 0x0600673B RID: 26427 RVA: 0x000F7FA8 File Offset: 0x000F61A8
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

		// Token: 0x0600673C RID: 26428 RVA: 0x000F8025 File Offset: 0x000F6225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x000F8030 File Offset: 0x000F6230
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

		// Token: 0x04003950 RID: 14672
		private static readonly MessageParser<EnableFunctionInfo> _parser = new MessageParser<EnableFunctionInfo>(() => new EnableFunctionInfo());

		// Token: 0x04003951 RID: 14673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003952 RID: 14674
		public const int TypeFieldNumber = 1;

		// Token: 0x04003953 RID: 14675
		private EnableFunctionType type_;

		// Token: 0x04003954 RID: 14676
		public const int IsEnableFieldNumber = 2;

		// Token: 0x04003955 RID: 14677
		private bool isEnable_;

		// Token: 0x04003956 RID: 14678
		public const int FBParamListFieldNumber = 3;

		// Token: 0x04003957 RID: 14679
		private object param_;

		// Token: 0x04003958 RID: 14680
		private EnableFunctionInfo.ParamOneofCase paramCase_;

		// Token: 0x02001764 RID: 5988
		public enum ParamOneofCase
		{
			// Token: 0x0400C5E6 RID: 50662
			None,
			// Token: 0x0400C5E7 RID: 50663
			FBParamList = 3
		}
	}
}
