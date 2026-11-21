using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F5 RID: 1525
	[NetMessage(EMessageId.FlyEquipAddNotify)]
	public sealed class FlyEquipAddNotify : IMessage<FlyEquipAddNotify>, IMessage, IEquatable<FlyEquipAddNotify>, IDeepCloneable<FlyEquipAddNotify>, IBufferMessage
	{
		// Token: 0x06008D8B RID: 36235 RVA: 0x00157C61 File Offset: 0x00155E61
		[NullableContext(1)]
		public static FlyEquipAddNotify Create()
		{
			return new FlyEquipAddNotify();
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x00157C68 File Offset: 0x00155E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06008D8D RID: 36237 RVA: 0x00157C6B File Offset: 0x00155E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlyEquipAddNotify.Descriptor;
			}
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x00157C72 File Offset: 0x00155E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify()
		{
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00157C85 File Offset: 0x00155E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify(FlyEquipAddNotify other) : this()
		{
			this.flySkins_ = other.flySkins_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x00157CAF File Offset: 0x00155EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify Clone()
		{
			return new FlyEquipAddNotify(this);
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06008D91 RID: 36241 RVA: 0x00157CB7 File Offset: 0x00155EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FlySkins
		{
			get
			{
				return this.flySkins_;
			}
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x00157CBF File Offset: 0x00155EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlyEquipAddNotify);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00157CCD File Offset: 0x00155ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlyEquipAddNotify other)
		{
			return other != null && (other == this || (this.flySkins_.Equals(other.flySkins_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00157D00 File Offset: 0x00155F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.flySkins_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x00157D34 File Offset: 0x00155F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x00157D41 File Offset: 0x00155F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x00157D4A File Offset: 0x00155F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flySkins_.WriteTo(ref output, FlyEquipAddNotify._repeated_flySkins_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x00157D74 File Offset: 0x00155F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.flySkins_.CalculateSize(FlyEquipAddNotify._repeated_flySkins_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00157DAD File Offset: 0x00155FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlyEquipAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.flySkins_.Add(other.flySkins_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x00157DDB File Offset: 0x00155FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x00157DE4 File Offset: 0x00155FE4
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.flySkins_.AddEntriesFrom(ref input, FlyEquipAddNotify._repeated_flySkins_codec);
				}
			}
		}

		// Token: 0x0400457B RID: 17787
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400457C RID: 17788
		public const int FlySkinsFieldNumber = 15;

		// Token: 0x0400457D RID: 17789
		private static readonly FieldCodec<int> _repeated_flySkins_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400457E RID: 17790
		private readonly RepeatedField<int> flySkins_ = new RepeatedField<int>();
	}
}
