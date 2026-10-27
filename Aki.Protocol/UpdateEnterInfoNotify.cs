using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001494 RID: 5268
	[NetMessage(EMessageId.UpdateEnterInfoNotify)]
	public sealed class UpdateEnterInfoNotify : IMessage<UpdateEnterInfoNotify>, IMessage, IEquatable<UpdateEnterInfoNotify>, IDeepCloneable<UpdateEnterInfoNotify>, IBufferMessage
	{
		// Token: 0x0601BDEB RID: 114155 RVA: 0x004078B1 File Offset: 0x00405AB1
		[NullableContext(1)]
		public static UpdateEnterInfoNotify Create()
		{
			return new UpdateEnterInfoNotify();
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x0601BDEC RID: 114156 RVA: 0x004078B8 File Offset: 0x00405AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x0601BDED RID: 114157 RVA: 0x004078BB File Offset: 0x00405ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnterInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601BDEE RID: 114158 RVA: 0x004078C2 File Offset: 0x00405AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify()
		{
		}

		// Token: 0x0601BDEF RID: 114159 RVA: 0x004078D5 File Offset: 0x00405AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify(UpdateEnterInfoNotify other) : this()
		{
			this.enterInfos_ = other.enterInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDF0 RID: 114160 RVA: 0x004078FF File Offset: 0x00405AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify Clone()
		{
			return new UpdateEnterInfoNotify(this);
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x0601BDF1 RID: 114161 RVA: 0x00407907 File Offset: 0x00405B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstEnterInfoPb> EnterInfos
		{
			get
			{
				return this.enterInfos_;
			}
		}

		// Token: 0x0601BDF2 RID: 114162 RVA: 0x0040790F File Offset: 0x00405B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnterInfoNotify);
		}

		// Token: 0x0601BDF3 RID: 114163 RVA: 0x0040791D File Offset: 0x00405B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnterInfoNotify other)
		{
			return other != null && (other == this || (this.enterInfos_.Equals(other.enterInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDF4 RID: 114164 RVA: 0x00407950 File Offset: 0x00405B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enterInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BDF5 RID: 114165 RVA: 0x00407984 File Offset: 0x00405B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDF6 RID: 114166 RVA: 0x00407991 File Offset: 0x00405B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDF7 RID: 114167 RVA: 0x0040799A File Offset: 0x00405B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enterInfos_.WriteTo(ref output, UpdateEnterInfoNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDF8 RID: 114168 RVA: 0x004079C4 File Offset: 0x00405BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enterInfos_.CalculateSize(UpdateEnterInfoNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BDF9 RID: 114169 RVA: 0x004079FD File Offset: 0x00405BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateEnterInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.enterInfos_.Add(other.enterInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BDFA RID: 114170 RVA: 0x00407A2B File Offset: 0x00405C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDFB RID: 114171 RVA: 0x00407A34 File Offset: 0x00405C34
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enterInfos_.AddEntriesFrom(ref input, UpdateEnterInfoNotify._repeated_enterInfos_codec);
				}
			}
		}

		// Token: 0x0400A040 RID: 41024
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A041 RID: 41025
		public const int EnterInfosFieldNumber = 8;

		// Token: 0x0400A042 RID: 41026
		private static readonly FieldCodec<InstEnterInfoPb> _repeated_enterInfos_codec = FieldCodec.ForMessage<InstEnterInfoPb>(66U, InstEnterInfoPb.Parser);

		// Token: 0x0400A043 RID: 41027
		private readonly RepeatedField<InstEnterInfoPb> enterInfos_ = new RepeatedField<InstEnterInfoPb>();
	}
}
