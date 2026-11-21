using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BC RID: 5052
	[NetMessage(EMessageId.TemporaryTeleportAllInfoNotify)]
	public sealed class TemporaryTeleportAllInfoNotify : IMessage<TemporaryTeleportAllInfoNotify>, IMessage, IEquatable<TemporaryTeleportAllInfoNotify>, IDeepCloneable<TemporaryTeleportAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601AE35 RID: 110133 RVA: 0x003EA8F3 File Offset: 0x003E8AF3
		[NullableContext(1)]
		public static TemporaryTeleportAllInfoNotify Create()
		{
			return new TemporaryTeleportAllInfoNotify();
		}

		// Token: 0x17005B10 RID: 23312
		// (get) Token: 0x0601AE36 RID: 110134 RVA: 0x003EA8FA File Offset: 0x003E8AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B11 RID: 23313
		// (get) Token: 0x0601AE37 RID: 110135 RVA: 0x003EA8FD File Offset: 0x003E8AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601AE38 RID: 110136 RVA: 0x003EA904 File Offset: 0x003E8B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify()
		{
		}

		// Token: 0x0601AE39 RID: 110137 RVA: 0x003EA917 File Offset: 0x003E8B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify(TemporaryTeleportAllInfoNotify other) : this()
		{
			this.allTemporaryTeleportInfo_ = other.allTemporaryTeleportInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE3A RID: 110138 RVA: 0x003EA941 File Offset: 0x003E8B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify Clone()
		{
			return new TemporaryTeleportAllInfoNotify(this);
		}

		// Token: 0x17005B12 RID: 23314
		// (get) Token: 0x0601AE3B RID: 110139 RVA: 0x003EA949 File Offset: 0x003E8B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TemporaryTeleportInfo> AllTemporaryTeleportInfo
		{
			get
			{
				return this.allTemporaryTeleportInfo_;
			}
		}

		// Token: 0x0601AE3C RID: 110140 RVA: 0x003EA951 File Offset: 0x003E8B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportAllInfoNotify);
		}

		// Token: 0x0601AE3D RID: 110141 RVA: 0x003EA95F File Offset: 0x003E8B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportAllInfoNotify other)
		{
			return other != null && (other == this || (this.allTemporaryTeleportInfo_.Equals(other.allTemporaryTeleportInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE3E RID: 110142 RVA: 0x003EA994 File Offset: 0x003E8B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allTemporaryTeleportInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE3F RID: 110143 RVA: 0x003EA9C8 File Offset: 0x003E8BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE40 RID: 110144 RVA: 0x003EA9D5 File Offset: 0x003E8BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE41 RID: 110145 RVA: 0x003EA9DE File Offset: 0x003E8BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allTemporaryTeleportInfo_.WriteTo(ref output, TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE42 RID: 110146 RVA: 0x003EAA08 File Offset: 0x003E8C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allTemporaryTeleportInfo_.CalculateSize(TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE43 RID: 110147 RVA: 0x003EAA41 File Offset: 0x003E8C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportAllInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allTemporaryTeleportInfo_.Add(other.allTemporaryTeleportInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE44 RID: 110148 RVA: 0x003EAA6F File Offset: 0x003E8C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE45 RID: 110149 RVA: 0x003EAA78 File Offset: 0x003E8C78
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.allTemporaryTeleportInfo_.AddEntriesFrom(ref input, TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
				}
			}
		}

		// Token: 0x04009D48 RID: 40264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D49 RID: 40265
		public const int AllTemporaryTeleportInfoFieldNumber = 11;

		// Token: 0x04009D4A RID: 40266
		private static readonly FieldCodec<TemporaryTeleportInfo> _repeated_allTemporaryTeleportInfo_codec = FieldCodec.ForMessage<TemporaryTeleportInfo>(90U, TemporaryTeleportInfo.Parser);

		// Token: 0x04009D4B RID: 40267
		private readonly RepeatedField<TemporaryTeleportInfo> allTemporaryTeleportInfo_ = new RepeatedField<TemporaryTeleportInfo>();
	}
}
