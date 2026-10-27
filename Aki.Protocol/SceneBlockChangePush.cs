using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001143 RID: 4419
	[NetMessage(EMessageId.SceneBlockChangePush)]
	public sealed class SceneBlockChangePush : IMessage<SceneBlockChangePush>, IMessage, IEquatable<SceneBlockChangePush>, IDeepCloneable<SceneBlockChangePush>, IBufferMessage
	{
		// Token: 0x060178FE RID: 96510 RVA: 0x0036BC08 File Offset: 0x00369E08
		[NullableContext(1)]
		public static SceneBlockChangePush Create()
		{
			return new SceneBlockChangePush();
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x060178FF RID: 96511 RVA: 0x0036BC0F File Offset: 0x00369E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06017900 RID: 96512 RVA: 0x0036BC12 File Offset: 0x00369E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockChangePush.Descriptor;
			}
		}

		// Token: 0x06017901 RID: 96513 RVA: 0x0036BC19 File Offset: 0x00369E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush()
		{
		}

		// Token: 0x06017902 RID: 96514 RVA: 0x0036BC37 File Offset: 0x00369E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush(SceneBlockChangePush other) : this()
		{
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this.deleteBlockId_ = other.deleteBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017903 RID: 96515 RVA: 0x0036BC72 File Offset: 0x00369E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush Clone()
		{
			return new SceneBlockChangePush(this);
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06017904 RID: 96516 RVA: 0x0036BC7A File Offset: 0x00369E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06017905 RID: 96517 RVA: 0x0036BC82 File Offset: 0x00369E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeleteBlockId
		{
			get
			{
				return this.deleteBlockId_;
			}
		}

		// Token: 0x06017906 RID: 96518 RVA: 0x0036BC8A File Offset: 0x00369E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockChangePush);
		}

		// Token: 0x06017907 RID: 96519 RVA: 0x0036BC98 File Offset: 0x00369E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockChangePush other)
		{
			return other != null && (other == this || (this.downloadBlockId_.Equals(other.downloadBlockId_) && this.deleteBlockId_.Equals(other.deleteBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017908 RID: 96520 RVA: 0x0036BCEC File Offset: 0x00369EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.downloadBlockId_.GetHashCode();
			num ^= this.deleteBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017909 RID: 96521 RVA: 0x0036BD2E File Offset: 0x00369F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601790A RID: 96522 RVA: 0x0036BD3B File Offset: 0x00369F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601790B RID: 96523 RVA: 0x0036BD44 File Offset: 0x00369F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockChangePush._repeated_downloadBlockId_codec);
			this.deleteBlockId_.WriteTo(ref output, SceneBlockChangePush._repeated_deleteBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601790C RID: 96524 RVA: 0x0036BD7C File Offset: 0x00369F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.downloadBlockId_.CalculateSize(SceneBlockChangePush._repeated_downloadBlockId_codec);
			num += this.deleteBlockId_.CalculateSize(SceneBlockChangePush._repeated_deleteBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601790D RID: 96525 RVA: 0x0036BDC8 File Offset: 0x00369FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockChangePush other)
		{
			if (other == null)
			{
				return;
			}
			this.downloadBlockId_.Add(other.downloadBlockId_);
			this.deleteBlockId_.Add(other.deleteBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601790E RID: 96526 RVA: 0x0036BE07 File Offset: 0x0036A007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601790F RID: 96527 RVA: 0x0036BE10 File Offset: 0x0036A010
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
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockChangePush._repeated_downloadBlockId_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.deleteBlockId_.AddEntriesFrom(ref input, SceneBlockChangePush._repeated_deleteBlockId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008BEB RID: 35819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BEC RID: 35820
		public const int DownloadBlockIdFieldNumber = 10;

		// Token: 0x04008BED RID: 35821
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008BEE RID: 35822
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();

		// Token: 0x04008BEF RID: 35823
		public const int DeleteBlockIdFieldNumber = 15;

		// Token: 0x04008BF0 RID: 35824
		private static readonly FieldCodec<int> _repeated_deleteBlockId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008BF1 RID: 35825
		private readonly RepeatedField<int> deleteBlockId_ = new RepeatedField<int>();
	}
}
