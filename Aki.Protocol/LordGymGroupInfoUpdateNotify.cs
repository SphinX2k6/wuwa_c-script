using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094E RID: 2382
	[NetMessage(EMessageId.LordGymGroupInfoUpdateNotify)]
	public sealed class LordGymGroupInfoUpdateNotify : IMessage<LordGymGroupInfoUpdateNotify>, IMessage, IEquatable<LordGymGroupInfoUpdateNotify>, IDeepCloneable<LordGymGroupInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D247 RID: 53831 RVA: 0x001F027F File Offset: 0x001EE47F
		[NullableContext(1)]
		public static LordGymGroupInfoUpdateNotify Create()
		{
			return new LordGymGroupInfoUpdateNotify();
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600D248 RID: 53832 RVA: 0x001F0286 File Offset: 0x001EE486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600D249 RID: 53833 RVA: 0x001F0289 File Offset: 0x001EE489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymGroupInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x001F0290 File Offset: 0x001EE490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify()
		{
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x001F02A3 File Offset: 0x001EE4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify(LordGymGroupInfoUpdateNotify other) : this()
		{
			this.lordGymGroupInfos_ = other.lordGymGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x001F02CD File Offset: 0x001EE4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify Clone()
		{
			return new LordGymGroupInfoUpdateNotify(this);
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600D24D RID: 53837 RVA: 0x001F02D5 File Offset: 0x001EE4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymGroupInfo> LordGymGroupInfos
		{
			get
			{
				return this.lordGymGroupInfos_;
			}
		}

		// Token: 0x0600D24E RID: 53838 RVA: 0x001F02DD File Offset: 0x001EE4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymGroupInfoUpdateNotify);
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x001F02EB File Offset: 0x001EE4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymGroupInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.lordGymGroupInfos_.Equals(other.lordGymGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D250 RID: 53840 RVA: 0x001F0320 File Offset: 0x001EE520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lordGymGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D251 RID: 53841 RVA: 0x001F0354 File Offset: 0x001EE554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D252 RID: 53842 RVA: 0x001F0361 File Offset: 0x001EE561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x001F036A File Offset: 0x001EE56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lordGymGroupInfos_.WriteTo(ref output, LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D254 RID: 53844 RVA: 0x001F0394 File Offset: 0x001EE594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lordGymGroupInfos_.CalculateSize(LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x001F03CD File Offset: 0x001EE5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymGroupInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lordGymGroupInfos_.Add(other.lordGymGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x001F03FB File Offset: 0x001EE5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x001F0404 File Offset: 0x001EE604
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lordGymGroupInfos_.AddEntriesFrom(ref input, LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
				}
			}
		}

		// Token: 0x040058DC RID: 22748
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058DD RID: 22749
		public const int LordGymGroupInfosFieldNumber = 12;

		// Token: 0x040058DE RID: 22750
		private static readonly FieldCodec<LordGymGroupInfo> _repeated_lordGymGroupInfos_codec = FieldCodec.ForMessage<LordGymGroupInfo>(98U, LordGymGroupInfo.Parser);

		// Token: 0x040058DF RID: 22751
		private readonly RepeatedField<LordGymGroupInfo> lordGymGroupInfos_ = new RepeatedField<LordGymGroupInfo>();
	}
}
