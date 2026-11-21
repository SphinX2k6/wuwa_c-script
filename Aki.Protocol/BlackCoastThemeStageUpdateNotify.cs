using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AC RID: 428
	[NetMessage(EMessageId.BlackCoastThemeStageUpdateNotify)]
	public sealed class BlackCoastThemeStageUpdateNotify : IMessage<BlackCoastThemeStageUpdateNotify>, IMessage, IEquatable<BlackCoastThemeStageUpdateNotify>, IDeepCloneable<BlackCoastThemeStageUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x0008027D File Offset: 0x0007E47D
		[NullableContext(1)]
		public static BlackCoastThemeStageUpdateNotify Create()
		{
			return new BlackCoastThemeStageUpdateNotify();
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x00080284 File Offset: 0x0007E484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x00080287 File Offset: 0x0007E487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeStageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0008028E File Offset: 0x0007E48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify()
		{
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000802A1 File Offset: 0x0007E4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify(BlackCoastThemeStageUpdateNotify other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000802CB File Offset: 0x0007E4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify Clone()
		{
			return new BlackCoastThemeStageUpdateNotify(this);
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000802D3 File Offset: 0x0007E4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackCoastThemeStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000802DB File Offset: 0x0007E4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeStageUpdateNotify);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000802E9 File Offset: 0x0007E4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeStageUpdateNotify other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x0008031C File Offset: 0x0007E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00080350 File Offset: 0x0007E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x0008035D File Offset: 0x0007E55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00080366 File Offset: 0x0007E566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stages_.WriteTo(ref output, BlackCoastThemeStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00080390 File Offset: 0x0007E590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stages_.CalculateSize(BlackCoastThemeStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000803C9 File Offset: 0x0007E5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeStageUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.stages_.Add(other.stages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000803F7 File Offset: 0x0007E5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00080400 File Offset: 0x0007E600
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, BlackCoastThemeStageUpdateNotify._repeated_stages_codec);
				}
			}
		}

		// Token: 0x040029C6 RID: 10694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029C7 RID: 10695
		public const int StagesFieldNumber = 10;

		// Token: 0x040029C8 RID: 10696
		private static readonly FieldCodec<BlackCoastThemeStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<BlackCoastThemeStageInfo>(82U, BlackCoastThemeStageInfo.Parser);

		// Token: 0x040029C9 RID: 10697
		private readonly RepeatedField<BlackCoastThemeStageInfo> stages_ = new RepeatedField<BlackCoastThemeStageInfo>();
	}
}
