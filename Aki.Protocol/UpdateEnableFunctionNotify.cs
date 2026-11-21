using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001506 RID: 5382
	[NetMessage(EMessageId.UpdateEnableFunctionNotify)]
	public sealed class UpdateEnableFunctionNotify : IMessage<UpdateEnableFunctionNotify>, IMessage, IEquatable<UpdateEnableFunctionNotify>, IDeepCloneable<UpdateEnableFunctionNotify>, IBufferMessage
	{
		// Token: 0x0601C864 RID: 116836 RVA: 0x00422995 File Offset: 0x00420B95
		[NullableContext(1)]
		public static UpdateEnableFunctionNotify Create()
		{
			return new UpdateEnableFunctionNotify();
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x0601C865 RID: 116837 RVA: 0x0042299C File Offset: 0x00420B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x0601C866 RID: 116838 RVA: 0x0042299F File Offset: 0x00420B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnableFunctionNotify.Descriptor;
			}
		}

		// Token: 0x0601C867 RID: 116839 RVA: 0x004229A6 File Offset: 0x00420BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify()
		{
		}

		// Token: 0x0601C868 RID: 116840 RVA: 0x004229B9 File Offset: 0x00420BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify(UpdateEnableFunctionNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C869 RID: 116841 RVA: 0x004229E3 File Offset: 0x00420BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableFunctionNotify Clone()
		{
			return new UpdateEnableFunctionNotify(this);
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x0601C86A RID: 116842 RVA: 0x004229EB File Offset: 0x00420BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnableFunctionInfo> FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
		}

		// Token: 0x0601C86B RID: 116843 RVA: 0x004229F3 File Offset: 0x00420BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnableFunctionNotify);
		}

		// Token: 0x0601C86C RID: 116844 RVA: 0x00422A01 File Offset: 0x00420C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnableFunctionNotify other)
		{
			return other != null && (other == this || (this.funcInfo_.Equals(other.funcInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C86D RID: 116845 RVA: 0x00422A34 File Offset: 0x00420C34
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

		// Token: 0x0601C86E RID: 116846 RVA: 0x00422A68 File Offset: 0x00420C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C86F RID: 116847 RVA: 0x00422A75 File Offset: 0x00420C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C870 RID: 116848 RVA: 0x00422A7E File Offset: 0x00420C7E
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

		// Token: 0x0601C871 RID: 116849 RVA: 0x00422AA8 File Offset: 0x00420CA8
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

		// Token: 0x0601C872 RID: 116850 RVA: 0x00422AE1 File Offset: 0x00420CE1
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

		// Token: 0x0601C873 RID: 116851 RVA: 0x00422B0F File Offset: 0x00420D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C874 RID: 116852 RVA: 0x00422B18 File Offset: 0x00420D18
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcInfo_.AddEntriesFrom(ref input, UpdateEnableFunctionNotify._repeated_funcInfo_codec);
				}
			}
		}

		// Token: 0x0400A483 RID: 42115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A484 RID: 42116
		public const int FuncInfoFieldNumber = 7;

		// Token: 0x0400A485 RID: 42117
		private static readonly FieldCodec<EnableFunctionInfo> _repeated_funcInfo_codec = FieldCodec.ForMessage<EnableFunctionInfo>(58U, EnableFunctionInfo.Parser);

		// Token: 0x0400A486 RID: 42118
		private readonly RepeatedField<EnableFunctionInfo> funcInfo_ = new RepeatedField<EnableFunctionInfo>();
	}
}
