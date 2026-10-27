using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001319 RID: 4889
	[NetMessage(EMessageId.SystemMarkHideInfoNotify)]
	public sealed class SystemMarkHideInfoNotify : IMessage<SystemMarkHideInfoNotify>, IMessage, IEquatable<SystemMarkHideInfoNotify>, IDeepCloneable<SystemMarkHideInfoNotify>, IBufferMessage
	{
		// Token: 0x06019FBB RID: 106427 RVA: 0x003C6722 File Offset: 0x003C4922
		[NullableContext(1)]
		public static SystemMarkHideInfoNotify Create()
		{
			return new SystemMarkHideInfoNotify();
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x06019FBC RID: 106428 RVA: 0x003C6729 File Offset: 0x003C4929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x06019FBD RID: 106429 RVA: 0x003C672C File Offset: 0x003C492C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SystemMarkHideInfoNotify.Descriptor;
			}
		}

		// Token: 0x06019FBE RID: 106430 RVA: 0x003C6733 File Offset: 0x003C4933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify()
		{
		}

		// Token: 0x06019FBF RID: 106431 RVA: 0x003C6746 File Offset: 0x003C4946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify(SystemMarkHideInfoNotify other) : this()
		{
			this.systemMarkHideInfo_ = other.systemMarkHideInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FC0 RID: 106432 RVA: 0x003C6770 File Offset: 0x003C4970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoNotify Clone()
		{
			return new SystemMarkHideInfoNotify(this);
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x06019FC1 RID: 106433 RVA: 0x003C6778 File Offset: 0x003C4978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SystemMarkHideInfoPb> SystemMarkHideInfo
		{
			get
			{
				return this.systemMarkHideInfo_;
			}
		}

		// Token: 0x06019FC2 RID: 106434 RVA: 0x003C6780 File Offset: 0x003C4980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SystemMarkHideInfoNotify);
		}

		// Token: 0x06019FC3 RID: 106435 RVA: 0x003C678E File Offset: 0x003C498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SystemMarkHideInfoNotify other)
		{
			return other != null && (other == this || (this.systemMarkHideInfo_.Equals(other.systemMarkHideInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FC4 RID: 106436 RVA: 0x003C67C4 File Offset: 0x003C49C4
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

		// Token: 0x06019FC5 RID: 106437 RVA: 0x003C67F8 File Offset: 0x003C49F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FC6 RID: 106438 RVA: 0x003C6805 File Offset: 0x003C4A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FC7 RID: 106439 RVA: 0x003C680E File Offset: 0x003C4A0E
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

		// Token: 0x06019FC8 RID: 106440 RVA: 0x003C6838 File Offset: 0x003C4A38
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

		// Token: 0x06019FC9 RID: 106441 RVA: 0x003C6871 File Offset: 0x003C4A71
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

		// Token: 0x06019FCA RID: 106442 RVA: 0x003C689F File Offset: 0x003C4A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FCB RID: 106443 RVA: 0x003C68A8 File Offset: 0x003C4AA8
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.systemMarkHideInfo_.AddEntriesFrom(ref input, SystemMarkHideInfoNotify._repeated_systemMarkHideInfo_codec);
				}
			}
		}

		// Token: 0x040097D3 RID: 38867
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097D4 RID: 38868
		public const int SystemMarkHideInfoFieldNumber = 6;

		// Token: 0x040097D5 RID: 38869
		private static readonly FieldCodec<SystemMarkHideInfoPb> _repeated_systemMarkHideInfo_codec = FieldCodec.ForMessage<SystemMarkHideInfoPb>(50U, SystemMarkHideInfoPb.Parser);

		// Token: 0x040097D6 RID: 38870
		private readonly RepeatedField<SystemMarkHideInfoPb> systemMarkHideInfo_ = new RepeatedField<SystemMarkHideInfoPb>();
	}
}
