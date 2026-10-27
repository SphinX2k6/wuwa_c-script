using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F5 RID: 4853
	public sealed class SurvivorsWeaponPbData : IMessage<SurvivorsWeaponPbData>, IMessage, IEquatable<SurvivorsWeaponPbData>, IDeepCloneable<SurvivorsWeaponPbData>, IBufferMessage
	{
		// Token: 0x06019CD7 RID: 105687 RVA: 0x003BFED6 File Offset: 0x003BE0D6
		[NullableContext(1)]
		public static SurvivorsWeaponPbData Create()
		{
			return new SurvivorsWeaponPbData();
		}

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x06019CD8 RID: 105688 RVA: 0x003BFEDD File Offset: 0x003BE0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x06019CD9 RID: 105689 RVA: 0x003BFEE0 File Offset: 0x003BE0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponPbData.Descriptor;
			}
		}

		// Token: 0x06019CDA RID: 105690 RVA: 0x003BFEE7 File Offset: 0x003BE0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData()
		{
		}

		// Token: 0x06019CDB RID: 105691 RVA: 0x003BFEEF File Offset: 0x003BE0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData(SurvivorsWeaponPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CDC RID: 105692 RVA: 0x003BFF08 File Offset: 0x003BE108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData Clone()
		{
			return new SurvivorsWeaponPbData(this);
		}

		// Token: 0x06019CDD RID: 105693 RVA: 0x003BFF10 File Offset: 0x003BE110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponPbData);
		}

		// Token: 0x06019CDE RID: 105694 RVA: 0x003BFF1E File Offset: 0x003BE11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019CDF RID: 105695 RVA: 0x003BFF3C File Offset: 0x003BE13C
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

		// Token: 0x06019CE0 RID: 105696 RVA: 0x003BFF62 File Offset: 0x003BE162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CE1 RID: 105697 RVA: 0x003BFF6F File Offset: 0x003BE16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CE2 RID: 105698 RVA: 0x003BFF78 File Offset: 0x003BE178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CE3 RID: 105699 RVA: 0x003BFF90 File Offset: 0x003BE190
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

		// Token: 0x06019CE4 RID: 105700 RVA: 0x003BFFB6 File Offset: 0x003BE1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CE5 RID: 105701 RVA: 0x003BFFD3 File Offset: 0x003BE1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CE6 RID: 105702 RVA: 0x003BFFDC File Offset: 0x003BE1DC
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

		// Token: 0x040096FC RID: 38652
		private UnknownFieldSet _unknownFields;
	}
}
