using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118D RID: 4493
	[NetMessage(EMessageId.SceneGamePlayInfoNotify)]
	public sealed class SceneGamePlayInfoNotify : IMessage<SceneGamePlayInfoNotify>, IMessage, IEquatable<SceneGamePlayInfoNotify>, IDeepCloneable<SceneGamePlayInfoNotify>, IBufferMessage
	{
		// Token: 0x06017FE8 RID: 98280 RVA: 0x0037DCF8 File Offset: 0x0037BEF8
		[NullableContext(1)]
		public static SceneGamePlayInfoNotify Create()
		{
			return new SceneGamePlayInfoNotify();
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x06017FE9 RID: 98281 RVA: 0x0037DCFF File Offset: 0x0037BEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x06017FEA RID: 98282 RVA: 0x0037DD02 File Offset: 0x0037BF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017FEB RID: 98283 RVA: 0x0037DD09 File Offset: 0x0037BF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify()
		{
		}

		// Token: 0x06017FEC RID: 98284 RVA: 0x0037DD1C File Offset: 0x0037BF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify(SceneGamePlayInfoNotify other) : this()
		{
			this.gamePlayInfo_ = other.gamePlayInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FED RID: 98285 RVA: 0x0037DD46 File Offset: 0x0037BF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayInfoNotify Clone()
		{
			return new SceneGamePlayInfoNotify(this);
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x06017FEE RID: 98286 RVA: 0x0037DD4E File Offset: 0x0037BF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneGamePlayInfo> GamePlayInfo
		{
			get
			{
				return this.gamePlayInfo_;
			}
		}

		// Token: 0x06017FEF RID: 98287 RVA: 0x0037DD56 File Offset: 0x0037BF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayInfoNotify);
		}

		// Token: 0x06017FF0 RID: 98288 RVA: 0x0037DD64 File Offset: 0x0037BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayInfoNotify other)
		{
			return other != null && (other == this || (this.gamePlayInfo_.Equals(other.gamePlayInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FF1 RID: 98289 RVA: 0x0037DD98 File Offset: 0x0037BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gamePlayInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017FF2 RID: 98290 RVA: 0x0037DDCC File Offset: 0x0037BFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FF3 RID: 98291 RVA: 0x0037DDD9 File Offset: 0x0037BFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FF4 RID: 98292 RVA: 0x0037DDE2 File Offset: 0x0037BFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gamePlayInfo_.WriteTo(ref output, SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FF5 RID: 98293 RVA: 0x0037DE0C File Offset: 0x0037C00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gamePlayInfo_.CalculateSize(SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017FF6 RID: 98294 RVA: 0x0037DE45 File Offset: 0x0037C045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gamePlayInfo_.Add(other.gamePlayInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FF7 RID: 98295 RVA: 0x0037DE73 File Offset: 0x0037C073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x0037DE7C File Offset: 0x0037C07C
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
					this.gamePlayInfo_.AddEntriesFrom(ref input, SceneGamePlayInfoNotify._repeated_gamePlayInfo_codec);
				}
			}
		}

		// Token: 0x04008EE7 RID: 36583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EE8 RID: 36584
		public const int GamePlayInfoFieldNumber = 6;

		// Token: 0x04008EE9 RID: 36585
		private static readonly FieldCodec<SceneGamePlayInfo> _repeated_gamePlayInfo_codec = FieldCodec.ForMessage<SceneGamePlayInfo>(50U, SceneGamePlayInfo.Parser);

		// Token: 0x04008EEA RID: 36586
		private readonly RepeatedField<SceneGamePlayInfo> gamePlayInfo_ = new RepeatedField<SceneGamePlayInfo>();
	}
}
