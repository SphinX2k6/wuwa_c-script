using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A8 RID: 424
	[NetMessage(EMessageId.BlackCoastThemeStageUpdateNotify)]
	public sealed class BlackCoastThemeStageUpdateNotify : IMessage<BlackCoastThemeStageUpdateNotify>, IMessage, IEquatable<BlackCoastThemeStageUpdateNotify>, IDeepCloneable<BlackCoastThemeStageUpdateNotify>, IBufferMessage
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x0007EB11 File Offset: 0x0007CD11
		[NullableContext(1)]
		public static BlackCoastThemeStageUpdateNotify Create()
		{
			return new BlackCoastThemeStageUpdateNotify();
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x0007EB18 File Offset: 0x0007CD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x0007EB1B File Offset: 0x0007CD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeStageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0007EB22 File Offset: 0x0007CD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify()
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0007EB35 File Offset: 0x0007CD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify(BlackCoastThemeStageUpdateNotify other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0007EB5F File Offset: 0x0007CD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageUpdateNotify Clone()
		{
			return new BlackCoastThemeStageUpdateNotify(this);
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0007EB67 File Offset: 0x0007CD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackCoastThemeStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0007EB6F File Offset: 0x0007CD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeStageUpdateNotify);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0007EB7D File Offset: 0x0007CD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeStageUpdateNotify other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0007EBB0 File Offset: 0x0007CDB0
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

		// Token: 0x060031C7 RID: 12743 RVA: 0x0007EBE4 File Offset: 0x0007CDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0007EBF1 File Offset: 0x0007CDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x0007EBFA File Offset: 0x0007CDFA
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

		// Token: 0x060031CA RID: 12746 RVA: 0x0007EC24 File Offset: 0x0007CE24
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

		// Token: 0x060031CB RID: 12747 RVA: 0x0007EC5D File Offset: 0x0007CE5D
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

		// Token: 0x060031CC RID: 12748 RVA: 0x0007EC8B File Offset: 0x0007CE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0007EC94 File Offset: 0x0007CE94
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, BlackCoastThemeStageUpdateNotify._repeated_stages_codec);
				}
			}
		}

		// Token: 0x0400294B RID: 10571
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400294C RID: 10572
		public const int StagesFieldNumber = 1;

		// Token: 0x0400294D RID: 10573
		private static readonly FieldCodec<BlackCoastThemeStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<BlackCoastThemeStageInfo>(10U, BlackCoastThemeStageInfo.Parser);

		// Token: 0x0400294E RID: 10574
		private readonly RepeatedField<BlackCoastThemeStageInfo> stages_ = new RepeatedField<BlackCoastThemeStageInfo>();
	}
}
