using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117D RID: 4477
	[NetMessage(EMessageId.SceneBlockChangePush)]
	public sealed class SceneBlockChangePush : IMessage<SceneBlockChangePush>, IMessage, IEquatable<SceneBlockChangePush>, IDeepCloneable<SceneBlockChangePush>, IBufferMessage
	{
		// Token: 0x06017E9F RID: 97951 RVA: 0x0037AF50 File Offset: 0x00379150
		[NullableContext(1)]
		public static SceneBlockChangePush Create()
		{
			return new SceneBlockChangePush();
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x06017EA0 RID: 97952 RVA: 0x0037AF57 File Offset: 0x00379157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x06017EA1 RID: 97953 RVA: 0x0037AF5A File Offset: 0x0037915A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockChangePush.Descriptor;
			}
		}

		// Token: 0x06017EA2 RID: 97954 RVA: 0x0037AF61 File Offset: 0x00379161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush()
		{
		}

		// Token: 0x06017EA3 RID: 97955 RVA: 0x0037AF7F File Offset: 0x0037917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush(SceneBlockChangePush other) : this()
		{
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this.deleteBlockId_ = other.deleteBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EA4 RID: 97956 RVA: 0x0037AFBA File Offset: 0x003791BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockChangePush Clone()
		{
			return new SceneBlockChangePush(this);
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x06017EA5 RID: 97957 RVA: 0x0037AFC2 File Offset: 0x003791C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x06017EA6 RID: 97958 RVA: 0x0037AFCA File Offset: 0x003791CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeleteBlockId
		{
			get
			{
				return this.deleteBlockId_;
			}
		}

		// Token: 0x06017EA7 RID: 97959 RVA: 0x0037AFD2 File Offset: 0x003791D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockChangePush);
		}

		// Token: 0x06017EA8 RID: 97960 RVA: 0x0037AFE0 File Offset: 0x003791E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockChangePush other)
		{
			return other != null && (other == this || (this.downloadBlockId_.Equals(other.downloadBlockId_) && this.deleteBlockId_.Equals(other.deleteBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EA9 RID: 97961 RVA: 0x0037B034 File Offset: 0x00379234
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

		// Token: 0x06017EAA RID: 97962 RVA: 0x0037B076 File Offset: 0x00379276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EAB RID: 97963 RVA: 0x0037B083 File Offset: 0x00379283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EAC RID: 97964 RVA: 0x0037B08C File Offset: 0x0037928C
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

		// Token: 0x06017EAD RID: 97965 RVA: 0x0037B0C4 File Offset: 0x003792C4
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

		// Token: 0x06017EAE RID: 97966 RVA: 0x0037B110 File Offset: 0x00379310
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

		// Token: 0x06017EAF RID: 97967 RVA: 0x0037B14F File Offset: 0x0037934F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EB0 RID: 97968 RVA: 0x0037B158 File Offset: 0x00379358
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockChangePush._repeated_downloadBlockId_codec);
						continue;
					}
				}
				else if (num == 80U || num == 82U)
				{
					this.deleteBlockId_.AddEntriesFrom(ref input, SceneBlockChangePush._repeated_deleteBlockId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E7E RID: 36478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E7F RID: 36479
		public const int DownloadBlockIdFieldNumber = 2;

		// Token: 0x04008E80 RID: 36480
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008E81 RID: 36481
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();

		// Token: 0x04008E82 RID: 36482
		public const int DeleteBlockIdFieldNumber = 10;

		// Token: 0x04008E83 RID: 36483
		private static readonly FieldCodec<int> _repeated_deleteBlockId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008E84 RID: 36484
		private readonly RepeatedField<int> deleteBlockId_ = new RepeatedField<int>();
	}
}
