using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B6 RID: 5046
	[NetMessage(EMessageId.TeleportUpdateNotify)]
	public sealed class TeleportUpdateNotify : IMessage<TeleportUpdateNotify>, IMessage, IEquatable<TeleportUpdateNotify>, IDeepCloneable<TeleportUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601ADA8 RID: 109992 RVA: 0x003E91A9 File Offset: 0x003E73A9
		[NullableContext(1)]
		public static TeleportUpdateNotify Create()
		{
			return new TeleportUpdateNotify();
		}

		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x0601ADA9 RID: 109993 RVA: 0x003E91B0 File Offset: 0x003E73B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x0601ADAA RID: 109994 RVA: 0x003E91B3 File Offset: 0x003E73B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601ADAB RID: 109995 RVA: 0x003E91BA File Offset: 0x003E73BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify()
		{
		}

		// Token: 0x0601ADAC RID: 109996 RVA: 0x003E91CD File Offset: 0x003E73CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify(TeleportUpdateNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADAD RID: 109997 RVA: 0x003E91F7 File Offset: 0x003E73F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify Clone()
		{
			return new TeleportUpdateNotify(this);
		}

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x0601ADAE RID: 109998 RVA: 0x003E91FF File Offset: 0x003E73FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601ADAF RID: 109999 RVA: 0x003E9207 File Offset: 0x003E7407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportUpdateNotify);
		}

		// Token: 0x0601ADB0 RID: 110000 RVA: 0x003E9215 File Offset: 0x003E7415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportUpdateNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADB1 RID: 110001 RVA: 0x003E9248 File Offset: 0x003E7448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADB2 RID: 110002 RVA: 0x003E927C File Offset: 0x003E747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADB3 RID: 110003 RVA: 0x003E9289 File Offset: 0x003E7489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADB4 RID: 110004 RVA: 0x003E9292 File Offset: 0x003E7492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TeleportUpdateNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADB5 RID: 110005 RVA: 0x003E92BC File Offset: 0x003E74BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TeleportUpdateNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADB6 RID: 110006 RVA: 0x003E92F5 File Offset: 0x003E74F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADB7 RID: 110007 RVA: 0x003E9323 File Offset: 0x003E7523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADB8 RID: 110008 RVA: 0x003E932C File Offset: 0x003E752C
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TeleportUpdateNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009D10 RID: 40208
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D11 RID: 40209
		public const int IdsFieldNumber = 14;

		// Token: 0x04009D12 RID: 40210
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009D13 RID: 40211
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
