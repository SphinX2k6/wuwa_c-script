using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001492 RID: 5266
	[NetMessage(EMessageId.UpdateEnableFunctionNotify)]
	public sealed class UpdateEnableFunctionNotify : IMessage<UpdateEnableFunctionNotify>, IMessage, IEquatable<UpdateEnableFunctionNotify>, IDeepCloneable<UpdateEnableFunctionNotify>, IBufferMessage
	{
		// Token: 0x0601BDC7 RID: 114119 RVA: 0x004074F1 File Offset: 0x004056F1
		[NullableContext(1)]
		public static UpdateEnableFunctionNotify Create()
		{
			return new UpdateEnableFunctionNotify();
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x0601BDC8 RID: 114120 RVA: 0x004074F8 File Offset: 0x004056F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x0601BDC9 RID: 114121 RVA: 0x004074FB File Offset: 0x004056FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnableFunctionNotify.Descriptor;
			}
		}

		// Token: 0x0601BDCA RID: 114122 RVA: 0x00407502 File Offset: 0x00405702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify()
		{
		}

		// Token: 0x0601BDCB RID: 114123 RVA: 0x00407515 File Offset: 0x00405715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify(UpdateEnableFunctionNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDCC RID: 114124 RVA: 0x0040753F File Offset: 0x0040573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify Clone()
		{
			return new UpdateEnableFunctionNotify(this);
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x0601BDCD RID: 114125 RVA: 0x00407547 File Offset: 0x00405747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnableFunctionInfo> FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
		}

		// Token: 0x0601BDCE RID: 114126 RVA: 0x0040754F File Offset: 0x0040574F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnableFunctionNotify);
		}

		// Token: 0x0601BDCF RID: 114127 RVA: 0x0040755D File Offset: 0x0040575D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnableFunctionNotify other)
		{
			return other != null && (other == this || (this.funcInfo_.Equals(other.funcInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x00407590 File Offset: 0x00405790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.funcInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x004075C4 File Offset: 0x004057C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDD2 RID: 114130 RVA: 0x004075D1 File Offset: 0x004057D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDD3 RID: 114131 RVA: 0x004075DA File Offset: 0x004057DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funcInfo_.WriteTo(ref output, UpdateEnableFunctionNotify._repeated_funcInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDD4 RID: 114132 RVA: 0x00407604 File Offset: 0x00405804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funcInfo_.CalculateSize(UpdateEnableFunctionNotify._repeated_funcInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BDD5 RID: 114133 RVA: 0x0040763D File Offset: 0x0040583D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateEnableFunctionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.funcInfo_.Add(other.funcInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BDD6 RID: 114134 RVA: 0x0040766B File Offset: 0x0040586B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDD7 RID: 114135 RVA: 0x00407674 File Offset: 0x00405874
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcInfo_.AddEntriesFrom(ref input, UpdateEnableFunctionNotify._repeated_funcInfo_codec);
				}
			}
		}

		// Token: 0x0400A038 RID: 41016
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A039 RID: 41017
		public const int FuncInfoFieldNumber = 4;

		// Token: 0x0400A03A RID: 41018
		private static readonly FieldCodec<EnableFunctionInfo> _repeated_funcInfo_codec = FieldCodec.ForMessage<EnableFunctionInfo>(34U, EnableFunctionInfo.Parser);

		// Token: 0x0400A03B RID: 41019
		private readonly RepeatedField<EnableFunctionInfo> funcInfo_ = new RepeatedField<EnableFunctionInfo>();
	}
}
