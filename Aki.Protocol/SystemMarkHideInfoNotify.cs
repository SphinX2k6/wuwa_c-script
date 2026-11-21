using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001386 RID: 4998
	[NetMessage(EMessageId.SystemMarkHideInfoNotify)]
	public sealed class SystemMarkHideInfoNotify : IMessage<SystemMarkHideInfoNotify>, IMessage, IEquatable<SystemMarkHideInfoNotify>, IDeepCloneable<SystemMarkHideInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A9CB RID: 109003 RVA: 0x003E09DE File Offset: 0x003DEBDE
		[NullableContext(1)]
		public static SystemMarkHideInfoNotify Create()
		{
			return new SystemMarkHideInfoNotify();
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x0601A9CC RID: 109004 RVA: 0x003E09E5 File Offset: 0x003DEBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x0601A9CD RID: 109005 RVA: 0x003E09E8 File Offset: 0x003DEBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SystemMarkHideInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x003E09EF File Offset: 0x003DEBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify()
		{
		}

		// Token: 0x0601A9CF RID: 109007 RVA: 0x003E0A02 File Offset: 0x003DEC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify(SystemMarkHideInfoNotify other) : this()
		{
			this.systemMarkHideInfo_ = other.systemMarkHideInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9D0 RID: 109008 RVA: 0x003E0A2C File Offset: 0x003DEC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify Clone()
		{
			return new SystemMarkHideInfoNotify(this);
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x0601A9D1 RID: 109009 RVA: 0x003E0A34 File Offset: 0x003DEC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SystemMarkHideInfoPb> SystemMarkHideInfo
		{
			get
			{
				return this.systemMarkHideInfo_;
			}
		}

		// Token: 0x0601A9D2 RID: 109010 RVA: 0x003E0A3C File Offset: 0x003DEC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SystemMarkHideInfoNotify);
		}

		// Token: 0x0601A9D3 RID: 109011 RVA: 0x003E0A4A File Offset: 0x003DEC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SystemMarkHideInfoNotify other)
		{
			return other != null && (other == this || (this.systemMarkHideInfo_.Equals(other.systemMarkHideInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9D4 RID: 109012 RVA: 0x003E0A80 File Offset: 0x003DEC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.systemMarkHideInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A9D5 RID: 109013 RVA: 0x003E0AB4 File Offset: 0x003DECB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9D6 RID: 109014 RVA: 0x003E0AC1 File Offset: 0x003DECC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9D7 RID: 109015 RVA: 0x003E0ACA File Offset: 0x003DECCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.systemMarkHideInfo_.WriteTo(ref output, SystemMarkHideInfoNotify._repeated_systemMarkHideInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A9D8 RID: 109016 RVA: 0x003E0AF4 File Offset: 0x003DECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.systemMarkHideInfo_.CalculateSize(SystemMarkHideInfoNotify._repeated_systemMarkHideInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A9D9 RID: 109017 RVA: 0x003E0B2D File Offset: 0x003DED2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SystemMarkHideInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.systemMarkHideInfo_.Add(other.systemMarkHideInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A9DA RID: 109018 RVA: 0x003E0B5B File Offset: 0x003DED5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9DB RID: 109019 RVA: 0x003E0B64 File Offset: 0x003DED64
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
					this.systemMarkHideInfo_.AddEntriesFrom(ref input, SystemMarkHideInfoNotify._repeated_systemMarkHideInfo_codec);
				}
			}
		}

		// Token: 0x04009BF5 RID: 39925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BF6 RID: 39926
		public const int SystemMarkHideInfoFieldNumber = 8;

		// Token: 0x04009BF7 RID: 39927
		private static readonly FieldCodec<SystemMarkHideInfoPb> _repeated_systemMarkHideInfo_codec = FieldCodec.ForMessage<SystemMarkHideInfoPb>(66U, SystemMarkHideInfoPb.Parser);

		// Token: 0x04009BF8 RID: 39928
		private readonly RepeatedField<SystemMarkHideInfoPb> systemMarkHideInfo_ = new RepeatedField<SystemMarkHideInfoPb>();
	}
}
