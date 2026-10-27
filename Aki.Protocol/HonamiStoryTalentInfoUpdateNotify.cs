using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A7 RID: 1959
	[NetMessage(EMessageId.HonamiStoryTalentInfoUpdateNotify)]
	public sealed class HonamiStoryTalentInfoUpdateNotify : IMessage<HonamiStoryTalentInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryTalentInfoUpdateNotify>, IDeepCloneable<HonamiStoryTalentInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B08F RID: 45199 RVA: 0x001A76E7 File Offset: 0x001A58E7
		[NullableContext(1)]
		public static HonamiStoryTalentInfoUpdateNotify Create()
		{
			return new HonamiStoryTalentInfoUpdateNotify();
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x0600B090 RID: 45200 RVA: 0x001A76EE File Offset: 0x001A58EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x001A76F1 File Offset: 0x001A58F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTalentInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B092 RID: 45202 RVA: 0x001A76F8 File Offset: 0x001A58F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify()
		{
		}

		// Token: 0x0600B093 RID: 45203 RVA: 0x001A770B File Offset: 0x001A590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify(HonamiStoryTalentInfoUpdateNotify other) : this()
		{
			this.honamiStoryTalentInfos_ = other.honamiStoryTalentInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B094 RID: 45204 RVA: 0x001A7735 File Offset: 0x001A5935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify Clone()
		{
			return new HonamiStoryTalentInfoUpdateNotify(this);
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600B095 RID: 45205 RVA: 0x001A773D File Offset: 0x001A593D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTalentInfo> HonamiStoryTalentInfos
		{
			get
			{
				return this.honamiStoryTalentInfos_;
			}
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x001A7745 File Offset: 0x001A5945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTalentInfoUpdateNotify);
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x001A7753 File Offset: 0x001A5953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTalentInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryTalentInfos_.Equals(other.honamiStoryTalentInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x001A7788 File Offset: 0x001A5988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryTalentInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B099 RID: 45209 RVA: 0x001A77BC File Offset: 0x001A59BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B09A RID: 45210 RVA: 0x001A77C9 File Offset: 0x001A59C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B09B RID: 45211 RVA: 0x001A77D2 File Offset: 0x001A59D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryTalentInfos_.WriteTo(ref output, HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B09C RID: 45212 RVA: 0x001A77FC File Offset: 0x001A59FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryTalentInfos_.CalculateSize(HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B09D RID: 45213 RVA: 0x001A7835 File Offset: 0x001A5A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTalentInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryTalentInfos_.Add(other.honamiStoryTalentInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B09E RID: 45214 RVA: 0x001A7863 File Offset: 0x001A5A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x001A786C File Offset: 0x001A5A6C
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
					this.honamiStoryTalentInfos_.AddEntriesFrom(ref input, HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
				}
			}
		}

		// Token: 0x04004F4B RID: 20299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F4C RID: 20300
		public const int HonamiStoryTalentInfosFieldNumber = 8;

		// Token: 0x04004F4D RID: 20301
		private static readonly FieldCodec<HonamiStoryTalentInfo> _repeated_honamiStoryTalentInfos_codec = FieldCodec.ForMessage<HonamiStoryTalentInfo>(66U, HonamiStoryTalentInfo.Parser);

		// Token: 0x04004F4E RID: 20302
		private readonly RepeatedField<HonamiStoryTalentInfo> honamiStoryTalentInfos_ = new RepeatedField<HonamiStoryTalentInfo>();
	}
}
