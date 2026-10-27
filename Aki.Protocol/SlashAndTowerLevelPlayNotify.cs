using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124A RID: 4682
	[NetMessage(EMessageId.SlashAndTowerLevelPlayNotify)]
	public sealed class SlashAndTowerLevelPlayNotify : IMessage<SlashAndTowerLevelPlayNotify>, IMessage, IEquatable<SlashAndTowerLevelPlayNotify>, IDeepCloneable<SlashAndTowerLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x06018F33 RID: 102195 RVA: 0x003A183E File Offset: 0x0039FA3E
		[NullableContext(1)]
		public static SlashAndTowerLevelPlayNotify Create()
		{
			return new SlashAndTowerLevelPlayNotify();
		}

		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x06018F34 RID: 102196 RVA: 0x003A1845 File Offset: 0x0039FA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06018F35 RID: 102197 RVA: 0x003A1848 File Offset: 0x0039FA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x06018F36 RID: 102198 RVA: 0x003A184F File Offset: 0x0039FA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify()
		{
		}

		// Token: 0x06018F37 RID: 102199 RVA: 0x003A1862 File Offset: 0x0039FA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify(SlashAndTowerLevelPlayNotify other) : this()
		{
			this.slashLevelPlayInfos_ = other.slashLevelPlayInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x003A188C File Offset: 0x0039FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify Clone()
		{
			return new SlashAndTowerLevelPlayNotify(this);
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06018F39 RID: 102201 RVA: 0x003A1894 File Offset: 0x0039FA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelPlayInfo> SlashLevelPlayInfos
		{
			get
			{
				return this.slashLevelPlayInfos_;
			}
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x003A189C File Offset: 0x0039FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerLevelPlayNotify);
		}

		// Token: 0x06018F3B RID: 102203 RVA: 0x003A18AA File Offset: 0x0039FAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerLevelPlayNotify other)
		{
			return other != null && (other == this || (this.slashLevelPlayInfos_.Equals(other.slashLevelPlayInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F3C RID: 102204 RVA: 0x003A18E0 File Offset: 0x0039FAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slashLevelPlayInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F3D RID: 102205 RVA: 0x003A1914 File Offset: 0x0039FB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F3E RID: 102206 RVA: 0x003A1921 File Offset: 0x0039FB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F3F RID: 102207 RVA: 0x003A192A File Offset: 0x0039FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slashLevelPlayInfos_.WriteTo(ref output, SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F40 RID: 102208 RVA: 0x003A1954 File Offset: 0x0039FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slashLevelPlayInfos_.CalculateSize(SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F41 RID: 102209 RVA: 0x003A198D File Offset: 0x0039FB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.slashLevelPlayInfos_.Add(other.slashLevelPlayInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F42 RID: 102210 RVA: 0x003A19BB File Offset: 0x0039FBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F43 RID: 102211 RVA: 0x003A19C4 File Offset: 0x0039FBC4
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.slashLevelPlayInfos_.AddEntriesFrom(ref input, SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
				}
			}
		}

		// Token: 0x04009320 RID: 37664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009321 RID: 37665
		public const int SlashLevelPlayInfosFieldNumber = 2;

		// Token: 0x04009322 RID: 37666
		private static readonly FieldCodec<SlashLevelPlayInfo> _repeated_slashLevelPlayInfos_codec = FieldCodec.ForMessage<SlashLevelPlayInfo>(18U, SlashLevelPlayInfo.Parser);

		// Token: 0x04009323 RID: 37667
		private readonly RepeatedField<SlashLevelPlayInfo> slashLevelPlayInfos_ = new RepeatedField<SlashLevelPlayInfo>();
	}
}
