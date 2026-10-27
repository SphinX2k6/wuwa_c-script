using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A12 RID: 2578
	[NetMessage(EMessageId.MoonPhaseRewardRequest)]
	public sealed class MoonPhaseRewardRequest : IMessage<MoonPhaseRewardRequest>, IMessage, IEquatable<MoonPhaseRewardRequest>, IDeepCloneable<MoonPhaseRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E182 RID: 57730 RVA: 0x00210803 File Offset: 0x0020EA03
		[NullableContext(1)]
		public static MoonPhaseRewardRequest Create()
		{
			return new MoonPhaseRewardRequest();
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600E183 RID: 57731 RVA: 0x0021080A File Offset: 0x0020EA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600E184 RID: 57732 RVA: 0x0021080D File Offset: 0x0020EA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E185 RID: 57733 RVA: 0x00210814 File Offset: 0x0020EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest()
		{
		}

		// Token: 0x0600E186 RID: 57734 RVA: 0x0021081C File Offset: 0x0020EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest(MoonPhaseRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E187 RID: 57735 RVA: 0x00210835 File Offset: 0x0020EA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest Clone()
		{
			return new MoonPhaseRewardRequest(this);
		}

		// Token: 0x0600E188 RID: 57736 RVA: 0x0021083D File Offset: 0x0020EA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRewardRequest);
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x0021084B File Offset: 0x0020EA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E18A RID: 57738 RVA: 0x0021086C File Offset: 0x0020EA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E18B RID: 57739 RVA: 0x00210892 File Offset: 0x0020EA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x0021089F File Offset: 0x0020EA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x002108A8 File Offset: 0x0020EAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E18E RID: 57742 RVA: 0x002108C0 File Offset: 0x0020EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E18F RID: 57743 RVA: 0x002108E6 File Offset: 0x0020EAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x00210903 File Offset: 0x0020EB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x0021090C File Offset: 0x0020EB0C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CAD RID: 23725
		private UnknownFieldSet _unknownFields;
	}
}
