using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001507 RID: 5383
	[NetMessage(EMessageId.UpdateEnableSystemNotify)]
	public sealed class UpdateEnableSystemNotify : IMessage<UpdateEnableSystemNotify>, IMessage, IEquatable<UpdateEnableSystemNotify>, IDeepCloneable<UpdateEnableSystemNotify>, IBufferMessage
	{
		// Token: 0x0601C876 RID: 116854 RVA: 0x00422B75 File Offset: 0x00420D75
		[NullableContext(1)]
		public static UpdateEnableSystemNotify Create()
		{
			return new UpdateEnableSystemNotify();
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x0601C877 RID: 116855 RVA: 0x00422B7C File Offset: 0x00420D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x0601C878 RID: 116856 RVA: 0x00422B7F File Offset: 0x00420D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnableSystemNotify.Descriptor;
			}
		}

		// Token: 0x0601C879 RID: 116857 RVA: 0x00422B86 File Offset: 0x00420D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify()
		{
		}

		// Token: 0x0601C87A RID: 116858 RVA: 0x00422B99 File Offset: 0x00420D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify(UpdateEnableSystemNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C87B RID: 116859 RVA: 0x00422BC3 File Offset: 0x00420DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify Clone()
		{
			return new UpdateEnableSystemNotify(this);
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x0601C87C RID: 116860 RVA: 0x00422BCB File Offset: 0x00420DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnableSystemFuncInfo> FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
		}

		// Token: 0x0601C87D RID: 116861 RVA: 0x00422BD3 File Offset: 0x00420DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnableSystemNotify);
		}

		// Token: 0x0601C87E RID: 116862 RVA: 0x00422BE1 File Offset: 0x00420DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnableSystemNotify other)
		{
			return other != null && (other == this || (this.funcInfo_.Equals(other.funcInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C87F RID: 116863 RVA: 0x00422C14 File Offset: 0x00420E14
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

		// Token: 0x0601C880 RID: 116864 RVA: 0x00422C48 File Offset: 0x00420E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C881 RID: 116865 RVA: 0x00422C55 File Offset: 0x00420E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C882 RID: 116866 RVA: 0x00422C5E File Offset: 0x00420E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funcInfo_.WriteTo(ref output, UpdateEnableSystemNotify._repeated_funcInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C883 RID: 116867 RVA: 0x00422C88 File Offset: 0x00420E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funcInfo_.CalculateSize(UpdateEnableSystemNotify._repeated_funcInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C884 RID: 116868 RVA: 0x00422CC1 File Offset: 0x00420EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateEnableSystemNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.funcInfo_.Add(other.funcInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C885 RID: 116869 RVA: 0x00422CEF File Offset: 0x00420EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C886 RID: 116870 RVA: 0x00422CF8 File Offset: 0x00420EF8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcInfo_.AddEntriesFrom(ref input, UpdateEnableSystemNotify._repeated_funcInfo_codec);
				}
			}
		}

		// Token: 0x0400A487 RID: 42119
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A488 RID: 42120
		public const int FuncInfoFieldNumber = 13;

		// Token: 0x0400A489 RID: 42121
		private static readonly FieldCodec<EnableSystemFuncInfo> _repeated_funcInfo_codec = FieldCodec.ForMessage<EnableSystemFuncInfo>(106U, EnableSystemFuncInfo.Parser);

		// Token: 0x0400A48A RID: 42122
		private readonly RepeatedField<EnableSystemFuncInfo> funcInfo_ = new RepeatedField<EnableSystemFuncInfo>();
	}
}
