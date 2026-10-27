using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001493 RID: 5267
	[NetMessage(EMessageId.UpdateEnableSystemNotify)]
	public sealed class UpdateEnableSystemNotify : IMessage<UpdateEnableSystemNotify>, IMessage, IEquatable<UpdateEnableSystemNotify>, IDeepCloneable<UpdateEnableSystemNotify>, IBufferMessage
	{
		// Token: 0x0601BDD9 RID: 114137 RVA: 0x004076D1 File Offset: 0x004058D1
		[NullableContext(1)]
		public static UpdateEnableSystemNotify Create()
		{
			return new UpdateEnableSystemNotify();
		}

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x0601BDDA RID: 114138 RVA: 0x004076D8 File Offset: 0x004058D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x0601BDDB RID: 114139 RVA: 0x004076DB File Offset: 0x004058DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnableSystemNotify.Descriptor;
			}
		}

		// Token: 0x0601BDDC RID: 114140 RVA: 0x004076E2 File Offset: 0x004058E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify()
		{
		}

		// Token: 0x0601BDDD RID: 114141 RVA: 0x004076F5 File Offset: 0x004058F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify(UpdateEnableSystemNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDDE RID: 114142 RVA: 0x0040771F File Offset: 0x0040591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnableSystemNotify Clone()
		{
			return new UpdateEnableSystemNotify(this);
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x0601BDDF RID: 114143 RVA: 0x00407727 File Offset: 0x00405927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnableSystemFuncInfo> FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
		}

		// Token: 0x0601BDE0 RID: 114144 RVA: 0x0040772F File Offset: 0x0040592F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnableSystemNotify);
		}

		// Token: 0x0601BDE1 RID: 114145 RVA: 0x0040773D File Offset: 0x0040593D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnableSystemNotify other)
		{
			return other != null && (other == this || (this.funcInfo_.Equals(other.funcInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDE2 RID: 114146 RVA: 0x00407770 File Offset: 0x00405970
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

		// Token: 0x0601BDE3 RID: 114147 RVA: 0x004077A4 File Offset: 0x004059A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDE4 RID: 114148 RVA: 0x004077B1 File Offset: 0x004059B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDE5 RID: 114149 RVA: 0x004077BA File Offset: 0x004059BA
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

		// Token: 0x0601BDE6 RID: 114150 RVA: 0x004077E4 File Offset: 0x004059E4
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

		// Token: 0x0601BDE7 RID: 114151 RVA: 0x0040781D File Offset: 0x00405A1D
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

		// Token: 0x0601BDE8 RID: 114152 RVA: 0x0040784B File Offset: 0x00405A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDE9 RID: 114153 RVA: 0x00407854 File Offset: 0x00405A54
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcInfo_.AddEntriesFrom(ref input, UpdateEnableSystemNotify._repeated_funcInfo_codec);
				}
			}
		}

		// Token: 0x0400A03C RID: 41020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A03D RID: 41021
		public const int FuncInfoFieldNumber = 1;

		// Token: 0x0400A03E RID: 41022
		private static readonly FieldCodec<EnableSystemFuncInfo> _repeated_funcInfo_codec = FieldCodec.ForMessage<EnableSystemFuncInfo>(10U, EnableSystemFuncInfo.Parser);

		// Token: 0x0400A03F RID: 41023
		private readonly RepeatedField<EnableSystemFuncInfo> funcInfo_ = new RepeatedField<EnableSystemFuncInfo>();
	}
}
